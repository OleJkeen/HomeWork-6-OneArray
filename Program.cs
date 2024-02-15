using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_OneArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayMaxNumber = 30;
            int arrayMinNumber = 1;
            int arraySize = 30;

            int[] arrayNumbers = new int[arraySize];
            Random random = new Random();
            int lastIndex = arrayNumbers.Length - 1;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = random.Next(arrayMinNumber, arrayMaxNumber + 1);
                Console.Write(arrayNumbers[i] + " ");
            }

            if (arrayNumbers[0] > arrayNumbers[1])
            {
                Console.WriteLine("\n\nПервый локальный максимум: " + arrayNumbers[0]);
            }

            for (int i = 1; i < arrayNumbers.Length - 1; i++)
            {
                if (arrayNumbers[i] > arrayNumbers[i - 1] && arrayNumbers[i] > arrayNumbers[i + 1])
                {
                    Console.WriteLine("\nЛокальный максимум: " + arrayNumbers[i]);
                }
            }

            if (arrayNumbers[arrayNumbers.Length - 1] > arrayNumbers[lastIndex - 1])
            {
                Console.WriteLine("\nПоследний локальный максимум: " + arrayNumbers[arrayNumbers.Length - 1]);
            }

            Console.ReadLine();
        }
    }
}
