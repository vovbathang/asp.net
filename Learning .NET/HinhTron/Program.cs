using System;

namespace HinhTron
{
    class HinhTron

    {
        public string BanKinh { get; set; }
        public HinhTron()
        {
            Console.WriteLine("Day la constructor khong nhan tham so");
        }
        public HinhTron(string banKinh)
        {
            this.BanKinh = banKinh;
            Console.WriteLine("Day la constructor nhan 1 tham so dau vao la " + banKinh);
        }
        static void Main(string[] args)
        {
            HinhTron hinhtron1 = new HinhTron();
            HinhTron hinhtron2 = new HinhTron("1");
            Console.ReadLine();
        }
    }
}
