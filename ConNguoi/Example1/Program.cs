using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         *************************************************       ");
            Console.WriteLine("         *                                               *       ");
            Console.WriteLine("         *       in ra man hinh 10 lan tong 2 so         *       ");
            Console.WriteLine("         *                                               *       ");
            Console.WriteLine("         *************************************************       ");

            int soA = 10;
            int soB = 20;
            for (int i=0; i<=10; i++)
            {
                soA = soA + i;
                soB += i;
                Console.WriteLine(TinhTong(soA, soB));

            }
            Console.ReadKey();
        }
        static int TinhTong (int a, int b)
        {
            int tong = a + b;
            return tong;
        }
    }
}
