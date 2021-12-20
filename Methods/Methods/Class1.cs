using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Class1
    {
        static void Main(string[] args)
        {

            bool flag = true;
            do
            {
                Console.WriteLine("Choose an Option");
                Console.WriteLine("1: calculate the income of an employee");
                Console.WriteLine("2: check whether you passed or fail");
                Console.WriteLine("3: Do you want to try our multiplication challenge?");
                Console.WriteLine("4: What about a look at the division challenge");
                Console.WriteLine("5: Let us show you how smart this robot chat is");
                Console.WriteLine("6: You think you are smart?");
                Console.WriteLine("7: Factorial");
                Console.WriteLine("8: Seansons");
                Console.WriteLine("9: Rock Paper Scissors");
                Console.WriteLine("10: Guess a number?");
                Console.WriteLine("11: Prime numbers?");
                Console.WriteLine("12: Cube challenge");
                Console.WriteLine("13: Integer challeng");
                Console.WriteLine("14: Multiplication table challenge");
                Console.WriteLine("15: Alphabetical order");
                Console.WriteLine("16: exist");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Calculator.First();
                        break;
                    case 2:
                        Calculator.Second();
                        break;
                    case 3:
                        Multiplication.Mult();
                        break;
                    case 4:
                        Multiplication.Div();
                        break;
                    case 5:
                        Compare.Big();
                        break;
                    case 6:
                        Compare.Even();
                        break;
                    case 7:
                        Game.Factorial();
                        break;
                    case 8:
                        Game.Season();
                        break;
                    case 9:
                        Game.Rock();
                        break;
                    case 10:
                        Console.WriteLine("Let do a guessing game if you think you are smart. Guess a number between 1 and 20");

                        int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };


                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(" Guess a number");
                            float z = float.Parse(Console.ReadLine());

                            if (z == myArray[5] && i < 3)
                            {
                                Console.WriteLine("You are smart");
                            }
                            else if (z == myArray[5])
                            {
                                Console.WriteLine("Try again");
                            }
                            else
                            {
                                Console.WriteLine("Game Over");
                            }
                        }
                        break;
                    case 11:
                        Console.WriteLine("Prime numbers");

                        Console.WriteLine(" Enter a number");
                        float numbe = float.Parse(Console.ReadLine());

                        int p = 0;
                        for (int i = 1; i <= numbe; i++)
                        {
                            if (numbe % i == 0)
                            {
                                p++;
                            }
                        }

                        if (p == 2)
                        {
                            Console.WriteLine(numbe + " is a prime number");
                        }
                        else
                        {
                            Console.WriteLine("The number is not a prime number");
                        }
                        break;
                    case 12:
                        Multitasking.Cube();
                        break;
                    case 13:
                        Multitasking.Avg();
                        break;
                    case 14:
                        Multitasking.Tab();
                        break;
                    case 15:
                        Multitasking.Alp();
                        break;
                    case 16:
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
