using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public static class Matrix
    {
        public static int[,] CreateMatrix(int line, int column)
        {
            int[,] ArrayOfNumbers = new int[line, column];
            string inputString = string.Empty;
            string[] stringArray;

            for (int i = 0; i < line; i++)
            {
                Console.WriteLine($"Введите элементы матрицы для строки {i + 1} через пробел");
                inputString = Console.ReadLine();
                stringArray = inputString.Split(' ');
                while (stringArray.Length != column || !Int32.TryParse(stringArray[i], out int number))
                {
                    Console.WriteLine("Введено неверное количество элементов или формат элементов некорректный!");
                    inputString = Console.ReadLine();
                    stringArray = inputString.Split(' ');
                }

                for (int j = 0; j < column; j++)
                {
                    ArrayOfNumbers[i, j] = Convert.ToInt32(stringArray[j]);
                }
            }
            return ArrayOfNumbers;
        }

        public static void Print(int[,] ArrayOfNumbers)
        {
            for (int i = 0; i < ArrayOfNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfNumbers.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,10}", ArrayOfNumbers[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
