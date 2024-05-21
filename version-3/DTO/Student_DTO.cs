using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student_DTO
    {
        pprivate string id, name, maLop;
private int tinhTrang;
Student_DTO(string name,string nganh,string maLop)
{
    this.name= name;
    
    this.maLop= maLop;
    tinhTrang = 1;
    
}
public string getMaLop() {  return this.maLop; }
public void setMaLop(string maLop) { this.maLop = maLop; }
public void setID(string id) { this.id = id;}
    }
}
