
namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 10;
            int maxNumber = 10;
            int columns = random.Next(minNumber, maxNumber);
            int rows = random.Next(minNumber, maxNumber);
            int[,] numbers = new int[rows, columns];
            int minValue = 0;
            int maxValue = 51;
            int maxNumberOfArray = 0;

            Console.WriteLine("Матрица: ");

            for (int i = 0; i < numbers.GetLength(0); i++)       // Вывод матрицы
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(minValue, maxValue);
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(0); i++)      // Поиск максимального(ых) числа(ел) матрицы
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    maxNumberOfArray = Math.Max(maxNumberOfArray, numbers[i, j]);
                }
            }

            Console.WriteLine("Наибольшее число матрицы равно: " + maxNumberOfArray);

            for (int i = 0; i < numbers.GetLength(0); i++)     // Поиск индекса числа 
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (maxNumberOfArray == numbers[i, j])
                    {
                        Console.WriteLine("Наибольшее число матрицы " + maxNumberOfArray + " находится по адресу: " + (i + 1) + "," + (j + 1));
                    }
                }
            }

            for (int i = 0; i < numbers.GetLength(0); i++)       // Вывод матрицы повторно
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j]  == maxNumberOfArray)
                    {
                        numbers[i, j] = 0;
                    }
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

