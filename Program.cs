using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print
            Console.WriteLine("Hello World");

            // Variables
            string name = "George";
            int age = 19;
            Console.WriteLine(name + " is " + age + " years old.");

            // Data type
            /* 
            string
            int
            char
            float, *double*, decimal
            bool
            */

            // string
            Console.WriteLine("Yu\nPeng");
            Console.WriteLine("Yu\"Peng");
            string myName = "Yu" + " Peng";
            int nameLength = myName.Length;
            Console.WriteLine(myName.ToUpper());
            Console.WriteLine(myName.Contains("Yu"));
            Console.WriteLine(myName[0]);
            Console.WriteLine(myName.IndexOf("Peng")); // -1 if not contained
            Console.WriteLine(myName.Substring(3, 4)); // start index, number of char

            // number
            Console.WriteLine();
            Console.WriteLine( 5 % 2); // Modular
            int num = 6;
            num++;
            num += 2;
            Console.WriteLine( Math.Abs(-40));
            Console.WriteLine( Math.Pow(3, 2));
            Console.WriteLine( Math.Sqrt(36));
            Console.WriteLine( Math.Round(3.6));
            Console.WriteLine( Math.Max(3, 6));

            // Input
            Console.Write("Enter your name: "); // Stay on the same line
            // string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);

            // Array
            int[] myNums = { 10, 20, 30 };
            Console.WriteLine(myNums[1]);
            myNums[0] = 5;
            string[] friends = new string[5];
            friends[0] = "Guisela";

            // Methods
            SayHi("Guisella");
            Console.WriteLine(Cube(2));

            // if statement
            int myAge = 19;
            if (myAge <= 18 && friends[0] == "Guisella" || myNums[0] <= 5)
            {
                Console.WriteLine(1);
            }
            else if (myNums[1] == 20)
            {
                Console.WriteLine(2);            }
            else
            {
                Console.WriteLine(3);
            }

            // While loop
            int index = 1;
            while (index != 10)
            {
                index++;
            }
            do
            {
                index++;
            } while (index != 20);

            // For loop
            for (index = 1; index <= 10; index++)
            {
                Console.WriteLine(index);
            }

            // 2D array
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 }
            };
            int[,,] numberCube = new int[3, 3, 3];

            Console.WriteLine(numberGrid[0, 0]);

            // Exception Handling
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }

            // Classes and Object
            // Book.cs
            Book HP = new Book();
            HP.title = "Harry Potter";
            HP.author = "JK Rowling";
            HP.pages = 1000;
            Book LR = new Book("Lord of the Ring", "someone", 100);

            // Static attribute
            Console.WriteLine(Book.bookCount);

            // Static class and static methods
            Tools.SayHello("Guisella");

            Console.ReadLine();
        }

        static void SayHi( string name )
        {
            Console.WriteLine("Hi" + name);
        }

        static int Cube (int num)
        {
            return num * num * num;
        }

        // Switch Statement
        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    dayName = "Not weekend";
                    break;
                default:
                    dayName = "Invalid";
                    break;
            }
            return dayName;
        }
    }
}
