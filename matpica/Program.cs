using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;
            // Запрашиваем у пользователя число строк и столбцов
            Console.WriteLine("Введите количество строк:");
            while (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("Некорректные данные. Пожалуйста, введите количество строк:");
            }

            Console.WriteLine("Введите количество столбцов:");
            while (!int.TryParse(Console.ReadLine(), out cols))
            {
                Console.WriteLine("Некорректные данные. Пожалуйста, введите корректное количество столбцов:");
            }
            // Создается массив и заполняется рандомными числами
            int[,] matrix = new int[rows, cols];
            Random random = new Random();
            // Вывод матрицы
            Console.WriteLine("Матрица создана!");
            int i = 0;
            while (i < rows)
            {
                int j = 0;
                while (j < cols)
                {
                    matrix[i, j] = random.Next(1, 101);  // Случайные целые числа от 1 до 100
                    Console.Write(matrix[i, j] + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            // Подсчет чисел в матрице
            int sum = 0;
            i = 0;
            while (i < rows)
            {
                int j = 0;
                while (j < cols)
                {
                    sum += matrix[i, j];
                    j++;
                }
                i++;
            }
            Console.WriteLine($"Сумма всех элементов матрицы: {sum}");
            Console.ReadKey();
        }
    }
}


