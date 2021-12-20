using System;

namespace Methods
{
    class Calculator
    {
        public static void First()
        {
            Console.WriteLine("Welcome to the Monthly Income calculator");

            Console.WriteLine("what is your wage?");
            float myWage = float.Parse(Console.ReadLine());

            Console.WriteLine("what are your hours per week?");
            int myHours = int.Parse(Console.ReadLine());

            int num_weeks = 4;

            float weekIncome = myWage * myHours;

            float monthIncome = weekIncome * num_weeks;

            Console.WriteLine("Your Monthly Income is " + monthIncome);
            Console.ReadKey();
        }

        public static void Second()
        {

            Console.WriteLine("Do You Want To Know If You Passed Or Failed?");

            Console.WriteLine("What is your grade for the course");
            float studentGrade = float.Parse(Console.ReadLine());

            const float courseGrade = 70;

            if (studentGrade >= courseGrade)
            {
                Console.WriteLine("You Passed successfully");
            }
            else
            {
                Console.WriteLine("You failed the course");
            }
        }
    }


    class Multiplication
    {
        public static void Mult()
        {
            Console.WriteLine("The multiplication challenge");

            Console.WriteLine("Enter your first number");
            float num1 = float.Parse(Console.ReadLine());



            if (num1 == 0)
            {
                Console.WriteLine("The results is 0");
            }
            else
            {
                Console.WriteLine("Enter your second number");
                float num2 = float.Parse(Console.ReadLine());
                float result = num1 * num2;
                Console.WriteLine("The result is " + result);
            }
        }

        public static void Div()
        {       
            Console.WriteLine("The Division Challenge");
            Console.WriteLine("Enter your first number");
            float numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            float numb2 = float.Parse(Console.ReadLine());

            if (numb2 == 0)
            {
                Console.WriteLine("Infinity");
            }
            else
            {
                float results = numb1 / numb2;
                Console.WriteLine("The result is " + results);
            }
        }
    }



    class Compare
    {
        public static void Big()
        {
            Console.WriteLine("wlecome to the comparison challenge");

            Console.WriteLine("Enter your first number");
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            float y = float.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("The first number is bigger than the second number");
            }
            else
            {
                Console.WriteLine("The second number is bigger than the first number");
            }
        }


        public static void Even()
        {     
            Console.WriteLine("wlecome to the even or odd number challenge");

            Console.WriteLine(" Enter a number");
            float newNum = float.Parse(Console.ReadLine());

            float res = newNum % 2;

            if (res == 0)
            {
                Console.WriteLine("The number is an even number");
            }
            else
            {
                Console.WriteLine("The number is a an odd number");
            }
        }
    }
    class Game
    {

        public static void Factorial()
        {
            Console.WriteLine("Please give me a positive integer.");
            int number1 = 0;
            try
            {
                number1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("You didn't type an integer. Sorry. I assumed you typed 0");
            }
            int factResult = Game.FactorialCalc(number1);
            Console.WriteLine(factResult);
        }

        public static int FactorialCalc(int number)
        {
            int result = 0;
            if (number == 0)
            {
                result = 1;
            }
            else
            {
                result = number * FactorialCalc(number - 1);
            }
            return result;
        }

        public static void Season()
        {
            Console.WriteLine("Please give me month and a day.");
            Console.WriteLine("Give me the month number. (1-12)");
            int testMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me the day number. (1-31)");
            int testDay = int.Parse(Console.ReadLine());
            int testYear = 2000; // Sets the year to 2000

            try
            {
                DateTime testDate = new DateTime(testYear, testMonth, testDay);
                DateTime firstDayOfSpring = new DateTime(testYear, 3, 22);
                DateTime firstDayOfSummer = new DateTime(testYear, 6, 21);
                DateTime firstDayOfFall = new DateTime(testYear, 9, 22);
                DateTime firstDayOfWinter = new DateTime(testYear, 12, 21);

                if (testDate < firstDayOfSpring)
                {
                    Console.WriteLine("Winter");
                }
                else if (testDate < firstDayOfSummer)
                {
                    Console.WriteLine("Spring");
                }
                else if (testDate < firstDayOfFall)
                {
                    Console.WriteLine("Summer");
                }
                else if (testDate < firstDayOfWinter)
                {
                    Console.WriteLine("Fall");
                }
                else
                {
                    Console.WriteLine("Winter");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("You did not enter a valid month and day.");
                Console.WriteLine(e);
            }
        }
        
        public static void Rock()
        {
            string playAgain = "y";
            do
            {
                Console.WriteLine("Let's play Rock, Paper, Scissors! Type r, p, or s");
                try
                {
                    string playerMove = Console.ReadLine();

                    string[] choices = { "r", "p", "s" };

                    Random randChoice = new Random();
                    var compChoice = randChoice.Next(0, 2);
                    string compMove = choices[compChoice];

                    if (compMove == playerMove)
                    {
                        Console.WriteLine("Computer picked {0}. That's a tie!", compMove);
                    }
                    else if (compMove == "r" && playerMove == "p")
                    {

                        Console.WriteLine("Computer picked {0}. You win.", compMove);
                    }
                    else if (compMove == "p" && playerMove == "s")
                    {
                        Console.WriteLine("Computer picked {0}. You win.", compMove);
                    }
                    else if (compMove == "s" && playerMove == "r")
                    {
                        Console.WriteLine("Computer picked {0}. You win.", compMove);
                    }
                    else
                    {
                        Console.WriteLine("Computer picked {0}. You lose.", compMove);
                    }
                    Console.WriteLine("Would you like to play again? y/n");
                    playAgain = Console.ReadLine();
                    if (playAgain != "y")
                    {
                        Console.WriteLine("Thanks for playing! Press any key to go back.");
                        Console.ReadKey();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You definitely messed up. Here is your error.");
                    Console.WriteLine(e);
                }
            } while (playAgain == "y");
        }
    }

    class Multitasking
    {
        public static void Cube()
        {
            Console.WriteLine("wlecome to the Cube challenge");

            Console.WriteLine("Enter a num number");
            float n = float.Parse(Console.ReadLine());

            float all = n * n * n;

            Console.WriteLine("Your ans is " + all); 
        }


        public static void Avg()
        {
            Console.WriteLine("wlecome to the integer challenge");

            Console.WriteLine(" Enter five random whole numbers");
            Console.WriteLine(" Enter the first number");
            float fi = float.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the second number");
            float se = float.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the third number");
            float th = float.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the fourth number");
            float fo = float.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the fifth number");
            float f_i = float.Parse(Console.ReadLine());
           


            float rest = fi + se + th + fo + f_i;
            float final = rest / 5;

            Console.WriteLine("The average is " + final);

        }

        public static void Tab()
        {
            Console.WriteLine("wlecome to the Multiplication table challenge");

            Console.WriteLine("Enter a whole number");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered " + w);

            int i;
            for (i = 1; i <= 10; i++)
            {
                int red = w * i;
                
                Console.WriteLine("Here we go " + w + " X " + i + " = " +red);
            }
        }

        public static void Alp()
        {
            Console.WriteLine("wlecome to the Alphabet order challenge");

            Console.WriteLine("Enter a two to three alphabes from A to I ");
            string p = (Console.ReadLine());
            string str = p.ToLower();

            if (str == "abc")
            {
                Console.WriteLine("the order is right");
            }
            else if (str == "def")
            {
                Console.WriteLine("the order is cool");
            }
            else if (str == "ghi")
            {
                Console.WriteLine("the order is great");
            }
            else
            {
                Console.WriteLine("the order is wrong");
            }
        }
    }
}
