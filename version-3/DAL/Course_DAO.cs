using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Course_DAO
    {
        public Dictionary<string,Course>getList(string maKhoa)
        {
            Dictionary<string,Course> list=new Dictionary<string,Course>();
            DataTable dt = DataAccess.getData("Select MaHocPhan,TenHocPhan,TinChi,LoaiHocPhan FROM HocPhan where maKhoa='" + maKhoa + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maHocPhan = dt.Rows[i]["MaHocPhan"].ToString();
                string tenHocPhan = dt.Rows[i]["TenHocPhan"].ToString();
                int tinChi = Convert.ToInt32(dt.Rows[i]["TinChi"]);
                bool loaiHocPhan = Convert.ToInt32(dt.Rows[i]["LoaiHocPhan"]) == 1;
                list.Add(maHocPhan, new Course(maHocPhan, tenHocPhan, loaiHocPhan, tinChi));
            }
            return list;
        }
        
    }
}
