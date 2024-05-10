﻿using System;
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
            var rooms = new List<Room>
        {
            new Room("123", "402", 35, true),
            new Room("234", "502", 40, false),
            new Room("235", "503", 40, false),
            new Room("236", "504", 40, false),
            new Room("124", "403", 40, true),
            new Room("125", "404", 40, true),

            // Add more rooms if needed
        };

            var courses = new List<Course>
        {
            new Course("111", "thuc tap lt", true, 3),
            new Course("222", "huong doi tuong", false, 4),
            new Course("112", "thuc tap huong doi tuong", true, 4),
            new Course("223", "co so du lieu", false, 4),
            new Course("225", "co so du lieu phan tan", false, 4),
            new Course("226", "cong nghe phan mem", false, 2),
            // Add more courses if needed
        };

            var teachers = new List<Teacher>
        {
            new Teacher("123", "Hoang", new List<Course> { courses[0], courses[3] }),
            new Teacher("125", "Hoang", new List<Course> { courses[0], courses[3], courses[2] }),
            new Teacher("234", "Nam", new List<Course> { courses[0], courses[1], courses[4], courses[5] }),
            new Teacher("235", "Nam Uq", new List<Course> { courses[0], courses[1], courses[2], courses[3] }),
            // Add more teachers if needed
        };

            var studentGroups = new List<StudentGroup>
        {
            new StudentGroup("hs1", "111", "dhti12", 23),
            new StudentGroup("hs2", "222", "dhti12", 32),
            new StudentGroup("hs3", "223", "dhti12", 32),
            new StudentGroup("hs4", "112", "dhti12", 32),
            new StudentGroup("hs5", "223", "dhti32", 32),
            new StudentGroup("hs6", "223", "dhti32", 32),
            new StudentGroup("hs7", "225", "dhti32", 32),
            new StudentGroup("hs8", "111", "dhti32", 32),
            new StudentGroup("hs9", "223", "dhti32", 32),
            new StudentGroup("hs10", "112", "dhti32", 32),
            new StudentGroup("hs11", "111", "dhti32", 32),
            new StudentGroup("hs12", "226", "dhti32", 32),
            new StudentGroup("hs13", "222", "dhti32", 32),
            new StudentGroup("hs14", "223", "dhti32", 32),
            new StudentGroup("hs15", "111", "dhti32", 32),
            new StudentGroup("hs16", "112", "dhti32", 32),
            
            // Add more student groups if needed
        };

            var data = new Data(rooms, teachers, courses, studentGroups);

            // Generate initial population
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
                    population[0].display();

                    break;
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
