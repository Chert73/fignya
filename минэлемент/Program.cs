using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace мин_элемент
{
    public class A
    {
        public void kto()
        {

            int min_ind = 0;
            int[] A = new int[15];

            Random r = new Random();

            for (int i = 0; i < A.Length; i++)
                A[i] = r.Next(0, 100);

            for (int i = 0; i < A.Length; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();

            int min;
            min = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                if (min > A[i])
                {
                    min = A[i];
                    min_ind = i;
                }

            }

            Console.WriteLine("\nМинимальное значение: " + min + "\nИндекс значения: " + min_ind);
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A mas = new A();
            mas.kto();
        }
    }
}
