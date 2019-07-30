using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConNguoi
{
    class Program
    {
        class NhanVien
        {
            string ten;
            string nghe;

            public void nhapten()
            {
                Console.Write("Nhap ten cua ban: ");
                ten = Console.ReadLine();
                Console.WriteLine("Ten ban la: " + ten);
                Console.ReadKey();
            }
            public void tuoi()
            {


                Random r = new Random();

                int n = r.Next(1, 40);
                if (n < 18)
                {
                    int m = n - 6;
                    Console.WriteLine("Ban " + n + " tuoi");
                    Console.WriteLine("Ban dang la hoc sinh");
                    if (m < 6)
                    {
                        Console.WriteLine("Ban dang hau mau giao");

                    }
                    else
                    {
                        Console.WriteLine("Ban dang hoc lop " + m);
                    }


                    Console.ReadLine();

                }
                else if (n == 18)
                {
                    Console.WriteLine("Ban " + n + " tuoi");
                    Console.WriteLine(" chưa rõ ban là hoc sinh hay nhân viên ");
                    Console.WriteLine("---------------------");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Ban " + n + " tuoi");
                    Console.WriteLine("Ban la nhan vien.");
                    Console.WriteLine("---------------------");
                    Console.ReadLine();

                }
            }
            public void nghenghiep()
            {
                Console.Write("Nghe nghiep cua ban: ");
                nghe = Console.ReadLine();
                Console.WriteLine("Nghe Nghiep cua ban la: " + nghe);
                Console.ReadKey();
            }
        }
        class HocSinh
        {
            string tenhs { get; set; }
            string lophs { get; set; }

            public void hs()
            {

            }

        }
        static void Main(string[] args)
        {
            
            NhanVien nv1 = new NhanVien();

            nv1.nhapten();
            nv1.nghenghiep();
            nv1.tuoi();

            NhanVien nv2 = new NhanVien();

            nv2.nhapten();
            nv2.nghenghiep();
            nv2.tuoi();

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
