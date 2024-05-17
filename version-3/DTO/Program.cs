using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rooms = new List<Room>
           
        {
            new Room("123", 35, true),
            new Room("234", 40, false),
            new Room("235", 40, false),
            new Room("236", 40, false),
            new Room("124", 40, true),
            new Room("125", 40, true),

            // Add more rooms if needed
        };
            
            var courses = new Dictionary<string, Course>
            {
             { "111", new Course("111", "thuc tap lt", true, 3) },
                 { "222", new Course("222", "huong doi tuong", false, 4) },
            { "112", new Course("112", "thuc tap huong doi tuong", true, 4) },
            { "223", new Course("223", "co so du lieu", false, 4) },
             { "225", new Course("225", "co so du lieu phan tan", false, 4) },
             { "227", new Course("227", "lap trinh .Net", false, 4) },
             { "229", new Course("229", "cong nghe java", false, 4) },
             { "226", new Course("226", "cong nghe phan mem", false, 2) }
    // Add more courses if needed
        };


            var teachers = new List<Teacher>
        {
             new Teacher("123", "Hoang", new List<string> { "111", "223" }),
             new Teacher("125", "Hoang", new List<string> { "227", "112", "229" }),
             new Teacher("125", "Hoang", new List<string> { "111", "223", "222" }),
              new Teacher("234", "Nam", new List<string> { "112", "222", "225", "226" }),
             new Teacher("235", "Nam Uq", new List<string> { "111", "222", "112", "223" })
            // Add more teachers if needed
        };

            var studentGroups = new List<StudentGroup>
        {
            new StudentGroup("hs1", "111", 23),
            new StudentGroup("hs2", "222", 32),
            new StudentGroup("hs3", "223", 32),
            new StudentGroup("hs4", "112", 32),
            new StudentGroup("hs5", "223", 32),
            new StudentGroup("hs6", "223", 32),
            new StudentGroup("hs7", "225", 32),
            new StudentGroup("hs8", "111", 32),
            new StudentGroup("hs9", "223", 32),
            new StudentGroup("hs10", "112", 32),
            new StudentGroup("hs11", "111", 32),
            new StudentGroup("hs12", "226", 32),
            new StudentGroup("hs13", "222", 32),
            new StudentGroup("hs14", "223", 32),
            new StudentGroup("hs15", "111", 32),
            new StudentGroup("hs16", "112", 32),
            new StudentGroup("hs17", "227", 32),
            new StudentGroup("hs18", "227", 32),
            new StudentGroup("hs19", "227", 32),
            new StudentGroup("hs20", "229", 32),
            new StudentGroup("hs21", "229", 32),
            new StudentGroup("hs22", "226", 32),
            new StudentGroup("hs23", "226", 32),
            
            // Add more student groups if needed
        };

            var data = new Data(rooms, teachers, courses, studentGroups);

            // Generate initial population
            
        }
    }
}
