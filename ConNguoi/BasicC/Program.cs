using System;

namespace BasicC
{
    class Program
    {
        // Return 
        /*static void Main(string[] args)
        {
            Console.WriteLine(ReturnNumber());
            Console.ReadKey();
        }
        static int ReturnNumber()
        {
            return 5;
        }*/

            // Truyen vao 2 tham so integer
        /*static void Main(string[] args)
        {
            Console.WriteLine(sumTwoNumber(5, 10));
            Console.ReadKey();
        }
        static int sumTwoNumber(int firstNumber, int secondNumber)
        {
            int sum;
            sum = firstNumber + secondNumber;
            return sum;
        }*/

            //truyen vao 2 tham so, string va int
        /*static void Main(string[] args)
        {
            printSomething("ABC", 123);
            printSomething("BCD", 345);
            Console.ReadKey();
        }
        static void printSomething(string name, int age)
        {
            Console.WriteLine("This is {0}, {1} tuoi.", name, age);
            return;
        }*/

        static void Main(string[] args)
        {
            Console.Write("Moi nhap ten cua ban: ");
            string name = Console.ReadLine();

            Console.Write("Moi ban nhap vao tuoi cua minh: ");
            int age = int.Parse(Console.ReadLine());

            if (age == 1)
            {
                Console.WriteLine("This is {0}, {1} year old.", name, age);
            }
            else if (age < 1)
            {
                Console.WriteLine("Ban nhap sai");
            }
            else
            {
                PrintSomething(name, age);
            }

            /*if(age >= 1)
            {
                Console.WriteLine("This is {0}, {1} years old.", name, age);
            }
            else
            {
                Console.WriteLine("Ban nhap sai");
            }*/

            Console.ReadKey();
        }
        static void PrintSomething(string name, int age)
        {
            Console.WriteLine("This is {0}, {1} years old.", name, age);
            return;
        }
    }
}
