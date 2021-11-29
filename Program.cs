using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа выполняет построение квадратной матрицы с размерногстью N");
            // Ввод данных
            Console.WriteLine("Введите размерность матрицы N: ");
            int[,] m;
            int t = Convert.ToInt32(Console.ReadLine());
            int n = t + 1;
            m = new int[n, n];
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (m[i, j] == 0)
                    {
                        m[i, j + 1] = 1;
                        m[i + 1, j] = 1;
                    }
                    else
                    {
                        m[i, j + 1] = 0;
                        m[i + 1, j] = 0;
                    }
                    Console.Write("{0}", m[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}