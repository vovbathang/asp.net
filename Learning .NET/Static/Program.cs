using System;

namespace Static
{
    class Program
    {
        public class Xe
        {
            //thuộc tính biển số xe
            public string BienSo { get; set; }

            //thuộc tính static đèn xe.
            public static string Den { get; set; }

            //hàm ChayStatic
            public static void ChayStatic()
            {
                Console.WriteLine("Xe dang chay");
            }

            //phương thức ChayNonStatic
            public void ChayNonStatic()
            {
                Console.WriteLine("Ham ChayNonStatic");
            }
        }
        static void Main(string[] args)
        {
            //static
            Xe.Den = "Den Vang";
            Xe.ChayStatic();

            //none static
            Xe xe = new Xe();
            xe.BienSo = "80B - 8888";
            xe.ChayNonStatic();
            Console.ReadLine();
        }
    }

    
}
