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

            PhepTru(2,1);
            Console.ReadLine();
        }

        static int PhepCong(int sothu1, int sothu2)
        {
            int tong;
            tong = sothu1 + sothu2;
            return tong;
        }

        static void PhepTru(int a, int b)
        {
            int hieu;
            hieu = a - b;
            Console.WriteLine("Hieu: {0}", hieu);
            Console.ReadLine();
        }
    }
}
