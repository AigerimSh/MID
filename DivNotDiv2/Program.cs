using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivNotDiv2
{

    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("Введите число элементов массива");
            n = Convert.ToInt16(Console.ReadLine());

            double[] Data = new double[n];
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Введите элементы массива");
                Data[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            // 
            for (i = 0; i < n; i++)
                if (Data[i] % 3 == 0 && Data[i] % 5 != 0)
                {
                    Console.WriteLine(Data[i]);
                }
            Console.ReadKey();
       
        }
       
    }
}
