using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentGroup_DAO
    {
        public List<StudentGroup>getList(string maKhoa) 
        { 
            List<StudentGroup> lst=new List<StudentGroup> ();
            DataTable dt = DataAccess.getData("SELECT LopHocPhan.MaLopHocPhan, LopHocPhan.MaHocPhan, LopHocPhan.SoHocSinh\r\nFROM LopHocPhan\r\nJOIN HocPhan ON HocPhan.MaHocPhan = LopHocPhan.MaHocPhan\r\nWHERE HocPhan.MaKhoa='"+maKhoa+"'");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string maLopHoc = dt.Rows[i]["MaLopHocPhan"].ToString();
                string maHocPhan = dt.Rows[i]["MaHocPhan"].ToString() ;
                int soHocSinh = Convert.ToInt32(dt.Rows[i]["SoHocSinh"]);
                lst.Add(new StudentGroup(maLopHoc, maHocPhan, soHocSinh));
            }
            return lst;

        }
    }
}
