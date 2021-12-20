using System;
using System.Collections;

namespace CollectionAss
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            do
            {
                Console.WriteLine("Choose an Option");
                Console.WriteLine("1: List Guest List");
                Console.WriteLine("2: Array Guest List");
                Console.WriteLine("3: Array Guest List");
                Console.WriteLine("4: To exist");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        GuestLists.first();
                        break;
                    case 2:
                        GuestLists.second();
                        break;
                    case 3:
                        FunGame.fouth();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("There is no such program");
                        break;

                }
            } while (flag);
        }

    }
}
