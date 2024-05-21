using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Student_DAO
    {
        public string getID(string maNganh)
        {
            string ret = DataAccess.getObj("SELECT MAX(SinhVien.maSV)\r\nFROM SinhVien\r\nJOIN LopHoc ON SinhVien.MaLop = LopHoc.MaLop\r\nWHERE LopHoc.MaNganh = '" + maNganh + "''");
            return ret;
        }
    }
}
