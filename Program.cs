using System;
using System.Collections;

namespace Homework4
{
    
    /*#region Задача №1
    public class Finance
    {
        /// <summary>
        /// параметры скрыты от клиентской программы
        /// </summary>
        private string[] _month = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        private int[] _income = new int[12];
        private int[] _expense = new int[12];
        private int[] _profit = new int[12];

        private int minProfitFirst, minProfitSecond, minProfitThree;
        private int maxProfitFirst, maxProfitSecond, maxProfitThree;
        /// <summary>
        /// конструктор класса
        /// </summary>
        /// <param name="data">объект класса Random</param>
        public Finance(Random data)
        {
            for (int i = 0; i < _month.Length; i++)
            {
                _income[i] = data.Next(1, 25);
                _expense[i] = data.Next(1, 25);
                _profit[i] = _income[i] - _expense[i];
            }
        }

        /// <summary>
        /// Печать на экран массивов
        /// </summary>
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\t{"Месяц",8}\t{"Доход",10}\t{ "Расходы",10}\t{"Прибыль",10}");
            Console.ResetColor();
            for (int i = 0; i < _month.Length; i++)
            {
                Console.WriteLine($"\t{_month[i],8}\t{_income[i],10}\t{_expense[i],10}\t{_profit[i],10}\n");
            }
        }

        void FindMaxMinProfit()
        {
            minProfitFirst = 0;//инициализация переменных
            minProfitSecond = 0;
            minProfitThree = _profit[0];
            maxProfitFirst = 0;
            maxProfitSecond = 0;
            maxProfitThree = _profit[0];

            for (int i = 1; i < _month.Length; i++)//поиск трех уникальных минимальных/максимальных прибылей
            {
                if (_profit[i] < 0)
                {
                    if (_profit[i] < minProfitThree)
                    {
                        minProfitFirst = minProfitSecond;
                        minProfitSecond = minProfitThree;
                        minProfitThree = _profit[i];
                    }
                    else
                    {
                        if (_profit[i] < minProfitSecond)
                        {
                            minProfitFirst = minProfitSecond;
                            minProfitSecond = _profit[i];
                        }
                        else if (_profit[i] < minProfitFirst)
                        {
                            minProfitFirst = _profit[i];
                        }
                    }
                }
                else
                {
                    if (_profit[i] > minProfitThree)
                    {
                        maxProfitFirst = maxProfitSecond;
                        maxProfitSecond = maxProfitThree;
                        maxProfitThree = _profit[i];
                    }
                    else
                    {
                        if (_profit[i] > maxProfitSecond)
                        {
                            maxProfitFirst = maxProfitSecond;
                            maxProfitSecond = _profit[i];
                        }
                        else if (_profit[i] > maxProfitFirst)
                        {
                            maxProfitFirst = _profit[i];
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// Печать на экран месяцев с минимальной прибылью
        /// </summary>
        public void PrintMinMaxProfit ()
        {
            FindMaxMinProfit();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Три худших месяца по прибыли для компании за последние 12 месяцев");
            Console.ResetColor();
            for (int i = 0; i < _month.Length; i++)//вывод на экран 
            {
                if(_profit[i] == minProfitFirst || _profit[i] == minProfitSecond || _profit[i] == minProfitThree)
                    Console.WriteLine($"\t{_month[i],8}\t{_profit[i],10}\n");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Три лучших месяца по прибыли для компании за последние 12 месяцев");
            Console.ResetColor();
            for (int i = 0; i < _month.Length; i++)//вывод на экран 
            {
                if (_profit[i] == maxProfitFirst || _profit[i] == maxProfitSecond || _profit[i] == maxProfitThree)
                    Console.WriteLine($"\t{_month[i],8}\t{_profit[i],10}\n");
            }
        }

    }   
    class Program
    {
        
        static void Main(string[] args)
        {
            Random fillBase = new Random ();
            
            Finance db = new Finance(fillBase);

            Console.WriteLine($"\t {"Финансовые показатели компании за 12 месяцев",10}\n");
            db.Print();
            db.PrintMinMaxProfit();
            Console.ReadKey();
        }
    }
    #endregion*/
    

    /*#region Задача №2
    class Program
    {
        public static float Factorial(int n)
        {
            float i, x = 1;
            for (i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }

        static void Main(string[] args)
        {
            int numberString;
            int c;
            int i;
            Console.WriteLine("Введите кол-во строк треугольника Паскаля: ");
            numberString = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < numberString; i++)
            {
                for (c = 0; c <= (numberString - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
                {
                    Console.Write(" ");
                }
                for (c = 0; c <= i; c++)
                {
                    Console.Write(" "); // создаём пробелы между элементами треугольника
                    Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c))); //формула вычисления элементов треугольника
                }
                Console.WriteLine();
                Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
            }
            Console.ReadLine();
        }
    }
    #endregion*/

    #region Задача №3


    class Program
    {
        /// <summary>
        /// Вывод матрицы на экран
        /// </summary>
        /// <param name="m"></param>
        static void PrintMatrix(int[,] m)
        {
            int count = 0;
            foreach (int z in m)
            {
                count++;
                if (count % m.GetLength(0) == 1) Console.WriteLine();
                Console.Write("{0,4}", z);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Заполнение матрицы случайными числами
        /// </summary>
        /// <param name="m"></param>
        /// <param name="r"></param>
        static void FillMatrix(int[,] m, Random r)
        {
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++) m[i,j] = r.Next(1, 20);
        }
        /// <summary>
        /// Умножение матрицы на число
        /// </summary>
        /// <param name="m"></param>
        /// <param name="multy"></param>
        static void MultyMatrix(int[,] m, int multy)
        {
            int count = 0;
            
            foreach (int k in m)
            {
                    count++;
                    if (count % m.GetLength(0) == 1) Console.WriteLine();
                    Console.Write("{0,4}", k * multy);
            }    
            
            Console.WriteLine();
        }
        /// <summary>
        /// Перемножение двух матриц
        /// </summary>
        /// <param name="m"></param>
        /// <param name="h"></param>
        static void FullMultyMatrix(int[,] m, int[,] h)
        {
            int count = 0;
            int temp = 0;
            if (m.GetLength(1) == h.GetLength(0))
            {
                for (int k = 0; k < m.GetLength(0); k++)
                {
                    for (int j = 0; j < h.GetLength(1); j++)
                    {
                        count++;
                        
                        for (int i = 0; i < m.GetLength(1); i++)
                        {
                            temp += m[k,i] * h[i,j];
                        }
                        Console.Write("{0,4}", temp);
                        if (count / m.GetLength(0) == 1)
                        {
                            Console.WriteLine();
                            count = 0;
                        }
                        temp = 0;
                    }
                }
            }
            else Console.WriteLine("Ошибка: Неверно заданы размеры матриц");
            Console.WriteLine();
        }
        /// <summary>
        /// Сумма двух матриц
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void SumMatrix(int[,] a, int[,] b)
        {
            int count = 0;
            if (a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1))
            {
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        count++;
                        if (count % a.GetLength(0) == 1) Console.WriteLine();
                        Console.Write("{0,4}", a[i, j] + b[i, j]);
                    }
            }
            else Console.WriteLine("Ошибка: Неверно заданы размеры матриц");
            Console.WriteLine();
        }
        /// <summary>
        /// Вычмтание матриц
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void SubtractionMatrix(int[,] a, int[,] b)
        {
            int count = 0;
            if (a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1))
            {
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        count++;
                        if (count % a.GetLength(0) == 1) Console.WriteLine();
                        Console.Write("{0,4}", a[i, j] - b[i, j]);
                    }
            }
            else Console.WriteLine("Ошибка: Неверно заданы размеры матриц");
            Console.WriteLine();
        }

        static int[,] matrix_1, matrix_2;//локальеые переменные матрицы
        static void Main(string[] args)
        {
            Random fillBase = new Random();
            Console.WriteLine("Введите размер матрицы №1 (от 1 до 20)");
            matrix_1 = new int [Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Введите размер матрицы №2 (от 1 до 20)");
            matrix_2 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];

            //заполнение матриц
            FillMatrix(matrix_1, fillBase);
            FillMatrix(matrix_2, fillBase);

            Console.WriteLine("Матрица №1");
            PrintMatrix(matrix_1);
            Console.WriteLine("Матрица №2");
            PrintMatrix(matrix_2);
            
            Console.WriteLine("Введите число для умножения матрицы 1 (от 1 до 100)");
            MultyMatrix(matrix_1, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите число для умножения матрицы 2 (от 1 до 100)");
            MultyMatrix(matrix_2, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Матрица после сложения");
            SumMatrix(matrix_1, matrix_2);
            Console.WriteLine("Матрица после вычитания");
            SubtractionMatrix(matrix_1, matrix_2);
            Console.WriteLine("Матрица после перемножения");
            FullMultyMatrix(matrix_1, matrix_2);

            Console.ReadLine();
        }
    }
    #endregion


}



