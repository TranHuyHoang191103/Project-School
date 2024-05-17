using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Room_DAO
    {
        public List<Room>getRooms(string maKhoa) {
            List<Room> rooms = new List<Room>();
            DataTable dt = DataAccess.getData("SELECT MaPhongHoc, SoCho, LoaiPhong FROM PhongHoc WHERE TinhTrang = 1 and maKhoa ='" + maKhoa + "'");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string maPhongHoc = dt.Rows[i]["MaPhongHoc"].ToString();
                int soCho = Convert.ToInt32(dt.Rows[i]["SoCho"]);
                bool loaiPhong = Convert.ToInt32(dt.Rows[i]["LoaiPhong"]) == 1;
                rooms.Add(new Room(maPhongHoc,soCho,loaiPhong));
            }
            return rooms;
        }
        
        
    }
}
