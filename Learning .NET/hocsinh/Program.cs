using System;

namespace hocsinh
{
    class Program
    {
        public class ConNguoi
        {
            public string HoTen { get; set; }
            public string CMND { get; set; }
            public void Hello()
            {
                Console.WriteLine("Xin chao" + HoTen);
            }
        }
        static void Main(string[] args)
        {
            ConNguoi nguoi = new ConNguoi();
            nguoi.HoTen = "Nguyen Van A";
            nguoi.CMND = "12344";
            nguoi.Hello();
            Console.ReadLine();
        }
    }
}

