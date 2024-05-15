using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeacherDTO
    {
        private string id;
        private string name;
        private string maKhoa;
        private string bangCap;
        private List<CourseDTO> courses;
        public TeacherDTO()
        {
            id = "";
            name = "";
            courses = new List<CourseDTO>();
        }
        public TeacherDTO(string id, string name, List<CourseDTO> courses)
        {
            this.id = id;
            this.name = name;
            this.courses = courses;
        }

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string BangCap { get => bangCap; set => bangCap = value; }

        public bool check(string id)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].getID() == id)
                    return true;
            }
            return false;
        }
        public string getID() { return id; }


        public string getName() { return name; }
    }
}
