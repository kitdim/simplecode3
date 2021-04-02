using System;

namespace SimpleCode8
{
    class Program
    {
        /// <summary>
        /// Увеличения массива
        /// </summary>
        /// <param name="ar"></param>
        static void Resize(ref int [] ar, int a)
        {
            int [] newar = new int[a];

            for (int i = 0; i < ar.Length && i < newar.Length; i++)
            {
                newar[i] = ar[i];
            }
            ar = newar;
        }
        static void Main(string[] args)
        {
            int [] myArray = { 1, 2, 3 };

            Resize(ref myArray, 10);
        }
    }
}
