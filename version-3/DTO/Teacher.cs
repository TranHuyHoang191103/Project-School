using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Teacher
    {
        private string id;
        private string name;
        private List<string> courses;
        public Teacher()
        {
            id = "";
            name = "";
            courses = new List<string>();
        }
        public Teacher(string id, string name, List<string> courses)
        {
            this.id = id;
            this.name = name;
            this.courses = courses;
        }
        public bool check(string id)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i] == id)
                    return true;
            }
            return false;
        }
        public string getID() { return id; }


        public string getName() { return name; }
    }
}
