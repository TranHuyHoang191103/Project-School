using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class Student
    {
        public string getNewID(Student_DTO t)
        {
            string str = DataAccess.getObj("SELECT MAX(SinhVien.maSV)\r\nFROM SinhVien\r\nJOIN LopHoc ON SinhVien.MaLop = LopHoc.MaLop\r\nWHERE LopHoc.MaNganh = '" + t.getNganh() + "t'");
            string cv = t.getNamHoc().ToString();
            int t1 = Convert.ToInt32(str);
            t1++;
            string tmp = t1.ToString();
            if (!(str[0] == cv[cv.Length - 2] || (str[1] != cv[cv.Length - 1]) && str.Length != 0) || str.Length == 0)
            {
                tmp = cv + t.getNganh() + "00001";
            }
            return tmp;
        }
        public string getLopHoc(string maNganh,int namHoc)
        {
            string str = DataAccess.getObj("SELECT MaLop \r\nFROM LopHoc \r\nWHERE SoSinhVien < 50 \r\nAND SoSinhVien = (SELECT MAX(SoSinhVien) FROM LopHoc WHERE SoSinhVien < 50 AND MaNganh='"+maNganh+"'AND NamVaoTruong='"+namHoc+"');\r\n");
            return str;
        }
        
    }
}
