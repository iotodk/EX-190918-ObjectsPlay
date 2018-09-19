using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsPlay.Objects
{
    class Car
    {
        public string Color;
        public int NumberOfDoors;
        public string Brand;
        public int YearOfFabrication;
        public int Price;
        public bool IsUsed;

        public override string ToString()
        {
            string text = Brand + " - " + NumberOfDoors + " - " + YearOfFabrication + " - " + Price;
            return text;
        }
        
    }
}
