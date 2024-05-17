using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class Schedule_BUS
    {
        public Schedule get(string maKhoa)
        {
            Room_DAO room_DAO=new Room_DAO();
            Teacher_DAO teacher_DAO=new Teacher_DAO();
            Course_DAO course_DAO=new Course_DAO();
            StudentGroup_DAO studentGroup_DAO=new StudentGroup_DAO();
            List<Room> rooms=room_DAO.getRooms(maKhoa);
            List<Teacher> teachers=teacher_DAO.getList(maKhoa);
            Dictionary<string, Course> courses=course_DAO.getList(maKhoa);
            List<StudentGroup> studentGroups=studentGroup_DAO.getList(maKhoa);
            Data data=new Data(rooms,teachers,courses,studentGroups);
            var population = new List<Schedule>();
            for (int i = 0; i < 100; i++)
            {
                var schedule = new Schedule(data);
                schedule.Initialize();
                population.Add(schedule);
            }

            // Genetic algorithm loop
            while (true)
            {
                population.Sort();


                if (population[0].getFitness() >= 1)
                {
                    return population[0];
                }


                var newGeneration = new List<Schedule>();
                for (int i = 0; i < 10; i++)
                {
                    newGeneration.Add(population[i]);
                }

                var random = new Random();
                for (int i = 0; i < 90; i++)
                {
                    int index1 = random.Next(population.Count);
                    int index2 = random.Next(population.Count);

                    var offspring = population[index1].mate(population[index2]);
                    newGeneration.Add(offspring);
                }

                population = newGeneration;
            }

        }
    }
}
