using System;

namespace MassimoMinimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 3, 6, -5, 4, 7 };

            int minimo = array[0];

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < minimo)
                    minimo = array[i];
            }

            Console.WriteLine(minimo);
            Console.ReadKey();
        }
    }
}
