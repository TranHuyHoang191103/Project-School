using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{   
    public class CourseOfMajor
    {
        private int nam, ki;
        private List<KeyValuePair<string, bool>> course;
        public CourseOfMajor(int nam, int ki,List<KeyValuePair<string,bool>>course)
        {
            this.nam = nam;
            this.ki = ki;
            this.course = course;
        }
        public List<KeyValuePair<string, bool>> getList()
        {
            return course;
        }
        public int getNam() { return nam; }
        public int getKi() {  return ki; }

    }
    public class Major
    {
        private string id, name;
        private List<CourseOfMajor> courses;
        public Major(string id,string name,List<CourseOfMajor>courses) {
            this.id= id;
            this.name= name;
            this.courses=courses;
            
        }
    }
}
