using System;

namespace Interface
{
    /*interface Xe
    {
        string BienSo { get; set; }

        void Chay();

        void BopCoi();
    }
    class XeMay : Xe
    {
        public string BienSo
        {
            get
            {
                return BienSo;
            }
            set
            {
                BienSo = value;
            }
        }

        public void Chay()
        {
            Console.WriteLine("Xe dang chay");
        }

        public void BopCoi()
        {
            Console.WriteLine("Xe dang bop coi");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Xe xeMay = new XeMay();
            xeMay.BopCoi();
            XeMay xeMay1 = new XeMay();
            Console.ReadLine();
        }
    }*/

    class HocSinh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thuc hien phep cong 2 so a va b:");
            int ketqua = phepcong(5, 6);
            Console.WriteLine(ketqua);
            Console.ReadLine();
           
            Console.WriteLine(sosanh(4, 5));
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
            }
            else
            {
                return false;
            }
        }
    }
}
