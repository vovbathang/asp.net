using System;

namespace LopCha
{
    class Program
    {
        public class LopCha
        {
            public string HinhDang { get; set; }

            protected string TamSu { get; set; }

            private string BiMat { get; set; }

            public void XuatHinhDang()
            {
                Console.WriteLine("Cha cho con hinh dang");
            }

            protected void XuatTamSu()
            {
                Console.WriteLine("cha trut bau tam su voi con");
            }

            private void XuatBiMat()
            {
                Console.WriteLine("Bi mat nay chi minh cha biet");
            }
        }
        class LopCon : LopCha
        {
            public void NgheTamSu()
            {
                base.XuatTamSu();
            }

            public void NhanHinhDang()
            {
                base.XuatHinhDang();
            }
        }
        static void Main(string[] args)
        {
            LopCha cha = new LopCha();
            cha.XuatHinhDang();
            
            LopCon con = new LopCon();
            con.NgheTamSu();
            con.NhanHinhDang();
            
            Console.ReadLine();
        }
    }
}
