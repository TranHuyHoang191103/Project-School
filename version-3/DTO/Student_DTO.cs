using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student_DTO
    {
        private string id, name, nganh, lop;
        private int tinhTrang,namHoc;
        Student_DTO(string name,string nganh,string Lop,int namHoc)
        {
            this.name= name;
            this.nganh= nganh;
            this.lop= Lop;
            tinhTrang = 1;
            this.namHoc= namHoc;
        }
        public string getNganh() { return  this.nganh; }
        public int getNamHoc() {  return this.namHoc; }
    }
}
