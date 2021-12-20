using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.light();

            Truck myTruck = new Truck();
            myTruck.light();

            Console.WriteLine(myCar.brand + " " + myCar.modelName + " with " + myCar.noOfDoor + " doors ");
            Console.WriteLine(myTruck.brand + " " + myTruck.modelName2 + " with " + myTruck.noOfDoors + " doors ");
        }
    }
}
