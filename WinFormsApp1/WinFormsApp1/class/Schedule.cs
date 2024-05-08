using SchoolManager;
using System;
using System.Collections.Generic; // Add this directive to use List<T>

public class Schedule
{
    private List<Class> classes;

    public Schedule()
    {
        classes = new List<Class>();
    }

    public Schedule Initialize(Data data)
    {
        List<Room> rooms = data.GetRooms();
        List<Teacher> teachers = data.GetTeachers();
        List<Course> courses = data.GetCourses();
        List<StudentGroup> studentGroups = data.GetStudentGroups();

        Random rd = new Random(); 

        for (int i = 0; i < studentGroups.Count; i++)
        {
            int rd_room = rd.Next(0, rooms.Count);
            int rd_teacher = rd.Next(0, teachers.Count);
            int rd_course = rd.Next(0, courses.Count);
            classes.Add(new Class(teachers[rd_teacher], courses[rd_course], studentGroups[i], rooms[rd_room]));
        }
        return this;
    }
    public double callFitness()
    {
        int number = 0;
        for(int i = 0; i < classes.Count-1; i++)
        {
            if (classes[i].getCourse().getIsPar() != classes[i].GetRoom().getIsParcticalLab())
                number++;
            if (classes[i].GetRoom().getNumberOfSeat()< classes[i].getStudentGroup().getNumberOfMember())
                number++;
            if (!classes[i].getTeacher().check(classes[i].getStudentGroup().getIdCoruse()))
                number++;    
            for (int j = i + 1; j < classes.Count; j++)
            {
                if (classes[i].GetRoom().getID() == classes[j].GetRoom().getID())
                {
                    if (classes[i].GetClassTime().check(classes[j].GetClassTime()))
                        number++;
                }
                if (classes[i].getTeacher().getID() == classes[j].getTeacher().getID())
                {
                    if (classes[i].GetClassTime().check(classes[j].GetClassTime()))
                        number++;
                }
                if (classes[i].getStudentGroup().getID()== classes[j].getStudentGroup().getID())
                {
                    if (classes[i].GetClassTime().check(classes[j].GetClassTime()))
                        number++;
                }
            }
        }
        return 1.0 / (number + 1);
    }
}
