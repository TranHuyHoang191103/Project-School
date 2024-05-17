using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Room
    {
        private string ID;
        private int numberOfSeat;
        bool isParctiacalLab;
        public Room(string ID,  int numberOfSeat, bool isParctiacalLab)
        {
            this.isParctiacalLab = isParctiacalLab;
            this.ID = ID; 
            this.numberOfSeat = numberOfSeat;
        }
        public string getID() { return ID; }

        public int getNumberOfSeat() { return numberOfSeat; }
        public bool getIsParcticalLab() { return isParctiacalLab; }

    }
}
