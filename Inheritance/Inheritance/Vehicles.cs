using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicles
    {
        public string brand = "Opel";

        public void light()
        {
            string wl = "white Light";
            string nl = "Normal Light";
            Console.WriteLine(wl + " and " + nl);
        }
    }

    class Car : Vehicles
    {
        public string modelName = "Astra";
        public int noOfDoor = 4;
        public string year = "2008";
    }

    class Truck : Vehicles
    {
        public string modelName2 = "Maultier";
        public int noOfDoors = 2;
        public string year = "1980";
    }
}
