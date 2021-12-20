using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAss
{
    class GuestLists
    {
        public static void first()
        {
            Console.WriteLine("wlecome to the GuestList");
            
            List<string> guestsList = new List<string>();
            
            bool flag = true;
            do
            {

                
                Console.WriteLine("Enter the name of guest");
                string name = (Console.ReadLine());
                guestsList.Add(name);


                Console.WriteLine("Do you want to enter another name?");
                Console.WriteLine("y or n");
                string yes = Console.ReadLine();

                if (yes.ToLower() == "y")
                {
                    
                }
                else
                {
                    flag = false;
                }
               
            } while (flag);
         
            foreach (string guest in guestsList)
            {
                Console.WriteLine(guest);
            }


        }

        public static void second()
        {
            Console.WriteLine("wlecome to the GuestList");

            ArrayList gueList = new ArrayList();

            bool flag = true;
            do
            {


                Console.WriteLine("Enter the name of guest");
                string name = (Console.ReadLine());
                gueList.Add(name);


                Console.WriteLine("Do you want to enter another name?");
                Console.WriteLine("y or n");
                string yes = Console.ReadLine();

                if (yes.ToLower() == "y")
                {

                }
                else
                {
                    flag = false;
                }

            } while (flag);

            foreach (string gues in gueList)
            {
                Console.WriteLine(gues);
            }


        }


        public static void third()
        {
            Console.WriteLine("wlecome to the GuestList");

            ArrayList gueList = new ArrayList();

            bool flag = true;
            do
            {


                Console.WriteLine("Enter the name of guest");
                string name = (Console.ReadLine());
                gueList.Add(name);


                Console.WriteLine("Do you want to enter another name?");
                Console.WriteLine("y or n");
                string yes = Console.ReadLine();

                if (yes.ToLower() == "y")
                {

                }
                else
                {
                    flag = false;
                }

            } while (flag);

            foreach (string gues in gueList)
            {
                Console.WriteLine(gues);
            }
        }

    }

    class FunGame
    {
        public static void fouth()
        {
            Console.WriteLine("wlecome to the Drawing Game");
            Console.WriteLine("Choose between number 3, 5 and 7");
            int bet = int.Parse(Console.ReadLine());

            if (bet == 3)
            {
                Console.WriteLine("***");
            }
            else if(bet == 5)
            {
                Console.WriteLine("*****");
            }
            else
            {
                Console.WriteLine("*******");
            }
        }
    }
}
