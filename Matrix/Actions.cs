using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public static class Actions
    {
        public static void FindAmountOfPositiveNumbers(int[,] ArrayOfNumbers)
        {
            int counter = 0;
            foreach (var item in ArrayOfNumbers)
            {
                if (item > 0)
                    counter++;
            }
            Console.WriteLine(counter);
        }

        public static void FindAmountOfNegativeNumbers(int[,] ArrayOfNumbers)
        {
            int counter = 0;
            foreach (var item in ArrayOfNumbers)
            {
                if (item < 0)
                    counter++;
            }
            Console.WriteLine(counter);
        }

        public static void BubbleSortIncreasing(int[,] ArrayOfNumbers)
        {
            Console.WriteLine("Выберете строку для сортировки");
            int line = Convert.ToInt32(Console.ReadLine()) - 1;
            int itemForReplace = 0;
            int counter = 0;
            while (counter < ArrayOfNumbers.GetLength(1))
            {
                for (int i = 0; i < ArrayOfNumbers.GetLength(1) - 1 - counter; i++)
                {
                    if (ArrayOfNumbers[line, i] > ArrayOfNumbers[line, i + 1])
                    {
                        itemForReplace = ArrayOfNumbers[line, i + 1];
                        ArrayOfNumbers[line, i + 1] = ArrayOfNumbers[line, i];
                        ArrayOfNumbers[line, i] = itemForReplace;
                    }
                }
                counter++;
            }
            Matrix.Print(ArrayOfNumbers);
        }

        public static void BubbleSortDecreasing(int[,] ArrayOfNumbers)
        {
            Console.WriteLine("Выберете строку для сортировки");
            int line = Convert.ToInt32(Console.ReadLine()) - 1;
            int itemForReplace = 0;
            int counter = 0;
            while (counter < ArrayOfNumbers.GetLength(1))
            {
                for (int i = 0; i < ArrayOfNumbers.GetLength(1) - 1 - counter; i++)
                {
                    if (ArrayOfNumbers[line, i] < ArrayOfNumbers[line, i + 1])
                    {
                        itemForReplace = ArrayOfNumbers[line, i + 1];
                        ArrayOfNumbers[line, i + 1] = ArrayOfNumbers[line, i];
                        ArrayOfNumbers[line, i] = itemForReplace;
                    }
                }
                counter++;
            }
            Matrix.Print(ArrayOfNumbers);
        }

        public static void Invert(int[,] ArrayOfNumbers)
        {
            Console.WriteLine("Выберете строку для инверсии");
            int line = Convert.ToInt32(Console.ReadLine()) - 1;
            int[] oneLineArray = new int[ArrayOfNumbers.GetLength(1)];
            int j = ArrayOfNumbers.GetLength(1) - 1;

            for (int i = 0; i < ArrayOfNumbers.GetLength(1); i++)
            {
                oneLineArray[j] = ArrayOfNumbers[line,i];
                j--;
            }

            int k = 0;
            foreach (int item in oneLineArray)
            {
                ArrayOfNumbers[line, k] = item;
                k++;
            }
            Matrix.Print(ArrayOfNumbers);
        }
    }
}
