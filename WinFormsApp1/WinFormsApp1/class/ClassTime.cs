using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager;

public class ClassTime
{
    private int day, dur, st, ed;
    
    public ClassTime(int dur)
    {
        Random random = new Random();
        this.dur = dur;
        day = random.Next(2,8);
        List<int> time= new List<int>();
        for (int i = 1; i <= 7 - dur; i++)
            time.Add(i);
        for(int i=7;i<=13-dur;i++)
            time.Add(i);
        st = random.Next(0,time.Count);
        ed = st + dur-1;            
    }
    public bool check(ClassTime other)
    {
        return !(day == other.day && st == other.st);
    }
}
