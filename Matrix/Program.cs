using Matrix;

Console.WriteLine("Введите количество строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество колонок");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Матрица размером {line} на {column}");
Console.WriteLine();

int[,] ArrayOfNumbers = Matrix.Matrix.CreateMatrix(line, column);
Matrix.Matrix.Print(ArrayOfNumbers);

Console.WriteLine();
Console.WriteLine("Выберете действие");
Console.WriteLine("1 - Количество положительных чисел в матрице");
Console.WriteLine("2 - Количество отрицательных чисел в матрице");
Console.WriteLine("3 - Сортировка элементов матрицы от меньшего к большему");
Console.WriteLine("4 - Сортировка элементов матрицы от большего к меньшему");
Console.WriteLine("5 - Инверсия элементов матрицы");

string action = Console.ReadLine();
switch (action)
{
    case "1":
        Actions.FindAmountOfPositiveNumbers(ArrayOfNumbers);
        break;
    case "2":
        Actions.FindAmountOfNegativeNumbers(ArrayOfNumbers);
        break;
    case "3":
        Actions.BubbleSortIncreasing(ArrayOfNumbers);
        break;
    case "4":
        Actions.BubbleSortDecreasing(ArrayOfNumbers);
        break;
    case "5":
        Actions.Invert(ArrayOfNumbers);
        break;
    default:
        Console.WriteLine("Невверный ввод");
        break;
}