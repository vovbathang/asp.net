using System;
using System.Collections.Generic;
using System.Text;

namespace ConNguoi
{
    class HocSinh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thuc hien phep cong 2 so a va b:");
            phepcong(5, 6);
            Console.ReadLine();
            sosanh(5, 4);
            Console.ReadLine();
        }
        static int phepcong(int a, int b)
        {
            int c = a + b;
            return c;
        }
        static bool sosanh(int c, int d)
        {

            if (c > d)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
