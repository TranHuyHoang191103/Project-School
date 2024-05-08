using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Room r1 = new Room("123", "402", 35, true);
            Room r2 = new Room("234", "502", 40, false);
            Course c1=new Course("111","thuc tap lt",true,3);
            Course c2=new Course("222","huong doi tuong",false,4);
            List<Course> lst_c=new List<Course>();
            lst_c.Add(c1);
            Teacher teacher = new Teacher("123","Hoang",lst_c);
            lst_c=new List<Course>();
            lst_c.Add(c1);
            lst_c.Add(c2);
            Teacher t2 = new Teacher("234", "Nam", lst_c);
            List<Room> lst_rooms = new List<Room>();
            lst_rooms.Add(r1);
            lst_rooms.Add(r2);
            List<Teacher> lst_Teacher=new List<Teacher>();
            lst_Teacher.Add(teacher);
            lst_Teacher.Add(t2);
            List<StudentGroup> lst_s=new List<StudentGroup>();
            lst_s.Add(new StudentGroup("hs1", "111", "dhti12", 23));
            lst_s.Add(new StudentGroup("hs2", "222", "dhti12", 32));
            lst_s.Add(new StudentGroup("hs3", "111", "dhti13", 22));

            Data data = new Data(lst_rooms,lst_Teacher,lst_c,lst_s);
            
            List<Schedule> population= new List<Schedule>();
            for(int i = 0; i < 100; i++)
            {
                Schedule T = new Schedule(data);
                T.Initialize();
                population.Add(T);
            }
            
            while (true)
            {
                population.Sort();
                if(population[0].getFitness()>=1) break;
                List<Schedule> newGen =new List<Schedule>();
                for(int i=0;i<10;i++)
                    newGen.Add(population[i]);
                Random rd = new Random(Guid.NewGuid().GetHashCode());
                for (int i = 0; i < 90; i++)
                {
                    int len = population.Count;
                    int r = rd.Next(0, len);
                    Schedule tmp_1 = population[r];
                    r = rd.Next(0, len);
                    Schedule tmp_2 = population[r];
                    Schedule tmp_3 = tmp_1.mate(tmp_2);
                    newGen.Add(tmp_3);
                }
                population = newGen;
            }
        }
    }
}
