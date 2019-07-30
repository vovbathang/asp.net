using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string A, B, C;
            float a, b, c;
            bool kta, ktb, ktc;

            Console.WriteLine("Nhap a: ");
            A = Console.ReadLine();
            kta = float.TryParse(A, out a);
            phepchia(a);

            Console.WriteLine("Tong 2 so: ", PhepCong(7, 9));
            Console.ReadLine();
        }

        public static void phepchia(float n)
        {
            float x;
            try
            {
                x = 1 / n;
                Console.WriteLine(x);
            }
            catch (DivideByZeroException ex)
            {
                //  Console.WriteLine(ex.Message);
                throw ex;
            }
            Console.ReadLine();
        }

        public static int PhepCong(int d, int e)
        {
            int tong;
            tong = d + e;
            return tong;
        }
    }
}
