using System;

namespace PhepCong
{
    class Program
    {
        static void Main()
        {
            int ketqua;
            ketqua = PhepCong(4, 7);
            Console.WriteLine("Tong 2 so: {0}", ketqua);
            Console.ReadLine();
        }

        static int PhepCong(int sothu1, int sothu2)
        {
            int tong;
            tong = sothu1 + sothu2;
            return tong;
        }
    }
}
