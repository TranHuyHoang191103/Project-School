using System;
using System.Collections.Generic;

namespace SchoolManager
{
    public class Data
    {
        private List<Room> rooms;
        private List<Teacher> teachers;
        private List<Course> courses;
        private List<StudentGroup> studentGroups;

        public Data()
        {
            rooms = new List<Room>();
            teachers = new List<Teacher>();
            courses = new List<Course>();
            studentGroups = new List<StudentGroup>();
        }

        public List<Room> GetRooms()
        {
            return rooms;
        }

         public List<Teacher>  GetTeachers() {  return teachers; }
         public List<Course> GetCourses() {  return courses; }
         public List <StudentGroup> GetStudentGroups() {  return studentGroups; }
    }

   
}
