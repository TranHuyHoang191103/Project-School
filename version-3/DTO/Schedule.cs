using ConsoleApp1;
using System;
using System.Collections.Generic; // Add this directive to use List<T>

public class Schedule : IComparable<Schedule>
{
    private List<Class> classes;
    private double fitness;
    private Data data;
    public Schedule(Data data)
    {
        classes = new List<Class>();
        this.data = data;
        fitness= 0;
    }
    public double getFitness() { return fitness; }
    public Schedule Initialize()
    {
        List<Room> rooms = data.GetRooms();
        List<Teacher> teachers = data.GetTeachers();
        Dictionary<string, Course> courses = data.GetCourses();
        List<StudentGroup> studentGroups = data.GetStudentGroups();

           Random rd = new Random(Guid.NewGuid().GetHashCode());

        for (int i = 0; i < studentGroups.Count; i++)
        {
            int rd_room = rd.Next(0, rooms.Count);
            int rd_teacher = rd.Next(0, teachers.Count);
            
            classes.Add(new Class(teachers[rd_teacher], courses[studentGroups[i].getIdCoruse()], studentGroups[i], rooms[rd_room]));
        }
        calFitness();
        return this;
    }
    public double calFitness()
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
                    if (!classes[i].GetClassTime().check(classes[j].GetClassTime()))
                        number++;
                }
                if (classes[i].getTeacher().getID() == classes[j].getTeacher().getID())
                {
                    if (!classes[i].GetClassTime().check(classes[j].GetClassTime()))
                        number++;
                }
                if (classes[i].getStudentGroup().getID()== classes[j].getStudentGroup().getID())
                {
                    if (!classes[i].GetClassTime().check(classes[j].GetClassTime()))
                        number++;
                }
            }

        }
        return fitness = 1.0 / (number + 1);
    }
    public void display()
    {
        for(int i=0;i<classes.Count; i++)
        {
            Console.Write(classes[i].getCourse().getID() + " " + classes[i].getTeacher().getID() + " " + classes[i].GetRoom().getID() + " " + classes[i].getStudentGroup().getID() + " ");
            classes[i].GetClassTime().display() ;
            Console.WriteLine();
        }
    }
    public Class mutation(int i)
    {
        List<Room> rooms = data.GetRooms();
        List<Teacher> teachers = data.GetTeachers();
        Dictionary<string,Course> courses = data.GetCourses();
        List<StudentGroup> studentGroups = data.GetStudentGroups();
        Random rd = new Random(Guid.NewGuid().GetHashCode());
        int rd_room = rd.Next(0, rooms.Count);
        int rd_teacher = rd.Next(0, teachers.Count);
        
        return (new Class(teachers[rd_teacher], courses[studentGroups[i].getIdCoruse()], studentGroups[i], rooms[rd_room])); 
    }
    public Schedule mate(Schedule schedule)
    {
        Schedule ret=new Schedule(data);
        Random rd = new Random(Guid.NewGuid().GetHashCode());
        for (int i = 0; i < classes.Count; i++)
        {
            float p = rd.Next(0, 101) / 100;
            if (p < 0.45)
                ret.classes.Add(classes[i]);
            else if (p < 0.90)
                ret.classes.Add(schedule.classes[i]);
            else ret.classes.Add(mutation(i));
        }
        ret.calFitness();
        return ret;
    }
    public int CompareTo(Schedule other)
    {
        if (other == null)
            return 1;

        // Compare based on fitness in descending order
        return other.getFitness().CompareTo(this.getFitness());
    }
}
