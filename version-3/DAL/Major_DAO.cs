using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Major_DAO
    {
        public CourseOfMajor get(string maNganh,int ki,int nam)
        {
            DataTable dt = DataAccess.getData("SELECT \r\n    ChiTietHPTheoNganh.MaHocPhan,\r\n    ChiTietHPTheoNganh.BatBuoc\r\nFROM \r\n    ChiTietHPTheoNganh\r\nJOIN \r\n    HocPhanTheoNganh \r\nON \r\n    HocPhanTheoNganh.MaHocPhanTheoNganh = ChiTietHPTheoNganh.MaHocPhanTheoNganh\r\nWHERE \r\n    HocPhanTheoNganh.MaNganh = '" + maNganh + "'\r\n    AND HocPhanTheoNganh.KyHoc = '" + ki + "'\r\n    AND HocPhanTheoNganh.NamHoc = '" + nam + "';");
            List<KeyValuePair<string,bool>>courses = new List<KeyValuePair<string,bool>>();
            foreach (DataRow dr in dt.Rows)
            {
                string maHocPhan = dr["MaHocPhan"].ToString();
                bool batBuoc = Convert.ToBoolean(dr["BatBuoc"]);
                courses.Add(new KeyValuePair<string, bool>(maHocPhan, batBuoc));
            }
            return new CourseOfMajor(nam, ki, courses);
        }
        public Major GetMajor(string maNganh)
        {
            string tenNganh = DataAccess.getObj("select TenNganh from NganhHoc where MaNganh='" + maNganh + "'");
            List<CourseOfMajor>courses = new List<CourseOfMajor>();
            for(int i = 1; i <= 4; i++)
            {
                courses.Add(get(maNganh, 1, i));
                courses.Add(get(maNganh, 2, i));
            }
            return new Major(maNganh, tenNganh, courses);
        }
    }
}
