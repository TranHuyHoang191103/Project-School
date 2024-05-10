using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Data
    {
        private List<Room> rooms;
        private List<Teacher> teachers;
        private Dictionary<string,Course> courses;
        private List<StudentGroup> studentGroups;

        public Data()
        {
            rooms = new List<Room>();
            teachers = new List<Teacher>();
            courses = new Dictionary<string, Course>();
            studentGroups = new List<StudentGroup>();
        }
        public Data(List<Room> rooms, List<Teacher> teachers, Dictionary<string,Course> courses, List<StudentGroup> studentGroups)
        {
            this.rooms = rooms;
            this.teachers = teachers;
            this.courses = courses;
            this.studentGroups = studentGroups;
        }

        public List<Room> GetRooms()
        {
            return rooms;
        }

         public List<Teacher>  GetTeachers() {  return teachers; }
         public Dictionary<string, Course> GetCourses() {  return courses; }
         public List <StudentGroup> GetStudentGroups() {  return studentGroups; }
    }

   
}
