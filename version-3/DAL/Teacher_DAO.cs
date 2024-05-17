using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Teacher_DAO
    {
        public List<Teacher> getList(string maKhoa)
        {
            List<Teacher> list = new List<Teacher>();
            DataTable dataTable = DataAccess.getData("select MaGiangVien,TenGiangVien FROM GIANGVIEN where TinhTrang=1 and MaKhoa='" + maKhoa + "'");
            for(int i=0;i<dataTable.Rows.Count;i++)
            {
                string maGiangVien = dataTable.Rows[i]["MaGiangVien"].ToString();
                string tenGiangVien = dataTable.Rows[i]["TenGiangVien"].ToString();
                DataTable dtCourseTeacher = DataAccess.getData("select MaHocPhan form GiangDay where MaGiangVien='" + maGiangVien + "'");
                List<string> c = new List<string>();
                for (int j = 0; j < dtCourseTeacher.Rows.Count; j++)
                {
                    c.Add(dtCourseTeacher.Rows[i]["MaHocPhan"].ToString());
                }
                list.Add(new Teacher(maGiangVien,tenGiangVien,c));
            }
            return list;
        }

    }
}
