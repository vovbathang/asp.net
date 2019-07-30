using System;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mang trong C#");
            Console.WriteLine("-----------------------");
            int[] n = new int[10]; /* n la mot mang gom 10 so nguyen */
            int i, j, k;
            /* khoi tao cac phan tu cua mang n */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
                Console.WriteLine("Phan tu {0}= {1}", i, n[i]);
            }
            /* hien thi gia tri cac phan tu cua mang n */
            Console.WriteLine("---------------");
            Console.WriteLine("Mang 2 chieu:");
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("---------------");
                for (k = 0; k < 10; k++)
                {
                    Console.WriteLine("Phan tu [{0}, {1}] = {2}", j, k, 1);
                }
            }
            Console.ReadKey();
        }
    }
}
