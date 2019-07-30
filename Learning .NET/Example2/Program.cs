using System;

namespace Example2
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

            Console.Write("Nhap b: ");
            B = Console.ReadLine();
            ktb = float.TryParse(B, out b);

            Console.Write("Nhap c: ");
            C = Console.ReadLine();
            ktc = float.TryParse(C, out c);

            if (kta == false || ktb == false || ktc == false)
            {
                Console.WriteLine("Du lieu nhap sai.");
                Console.ReadKey();
                return;
            }

            else
            {
                Console.WriteLine("Phuong trinh co dang: ");
                Console.WriteLine("{0}x^2 + {1}x + {2} = 0", a, b, c);
            }
            PTB1(a, b, c);
            Console.ReadKey();
        }

        static void PTB1(float a, float b, float c)
        {
            float x;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else
                {
                    x = -c / b;
                    Console.WriteLine("Phuong trinh co 1 nghiem: x= " + x);
                }
            }
            else
            {
                PTB2(a, b, c);
            }
        }

        static void PTB2(float a, float b, float c)
        {
            float x1, x2;
            double delta;

            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep x1= ", x1);
            }
            else
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet, x1= {0}, x2= {1}", x1, x2);
            }
        }
    }
}
