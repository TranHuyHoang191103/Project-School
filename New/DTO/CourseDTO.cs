using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CourseDTO
    {
        private string ID;
        private string name;
        private bool isParctitalCoruse;
        private int numberOfLesson;
        public CourseDTO(string ID, string name, bool isParctitalCourse, int numberOfLesson)
        {
            this.isParctitalCoruse = isParctitalCourse;
            this.ID = ID;
            this.name = name;
            this.numberOfLesson = numberOfLesson;
        }
        public string getID() { return this.ID; }
        public string getName() { return this.name; }
        public int getNumberOfLesson() { return this.numberOfLesson; }
        public bool getIsPar() { return this.isParctitalCoruse; }
    }
}
