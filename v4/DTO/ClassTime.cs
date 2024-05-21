using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ClassTime
    {
        private int day, dur, st, ed;
  
        public ClassTime(int dur)
        {
            this.dur = dur;
            Random random = new Random(Guid.NewGuid().GetHashCode());
            day = random.Next(2, 8);
            List<int> time = new List<int>();
            for (int i = 1; i <= 7 - dur; i++)
                time.Add(i);
            for (int i = 7; i <= 13 - dur; i++)
                time.Add(i);
            
            int x = random.Next(0, time.Count);
            st = time[x];
            ed = st + dur - 1;
        }
        public bool check(ClassTime other)
        {
            if (day == other.day)
            {
                if ((st >= other.st && st <= other.ed) || (st <= other.ed && ed >= other.st))
                {
                    return false;
                }
            }
                return true;
        }
        public void display() {
           Console.Write(" "+day+" "+st+" "+dur+" "+ed);
        }
    }
}
