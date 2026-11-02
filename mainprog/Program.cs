using System.DirectoryServices.ActiveDirectory;
namespace mainprog;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("№ Лабораторная работа №4. Выполнили Илья Зеленев и Станислав Сахаров, бТИИ-251");
            Console.WriteLine("№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№");
            Console.WriteLine("№ 1) Сформировать одномерный (длиной n) и двумерный (длиной n на m) массивы по заданному правилу");
            Console.WriteLine("№ 2) Первым на печать вывести массив, сумма значений которого окажется наименьшей");
            Console.WriteLine("№ 3) Найти сумму всех элементов массива, расположенных выше главной диагонали");
            Console.WriteLine("№ 4) Сортировка элементов массива простым выбором");
            Console.WriteLine("№ 5) Массив массивов трёх различных объектов с различными свойствами");
            Console.WriteLine("№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№");
            Console.Write("№ Введите номер задания: ");
            
            string? input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("№ Сформировать одномерный (длиной n) и двумерный (длиной n на m) массивы по заданному правилу");
                            Console.WriteLine("№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№");
                            Console.Write("№ Введите значение длины для одномерного массива: ");

                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            if (!int.TryParse(input, out int N))
                            {
                                Console.WriteLine($"Ошибка! Вы ввели {input}, а надо ввести целое число!\nПопробуйте ещё раз!");
                                Console.ReadKey();
                                continue;
                            }

                            Console.Write("Введите значение длины для двумерного массива: ");

                            input = Console.ReadLine();

                            if (!int.TryParse(input, out int M))
                            {
                                Console.WriteLine($"Ошибка! Вы ввели {input}, а надо ввести целое число!\nПопробуйте ещё раз!");
                                Console.ReadKey();
                                continue;
                            }

                            var n = new double[N];
                            var m = new double[M, N];

                            Random r = new Random();

                            for (int i = 0; i < N; i++)
                                n[i] = Math.Sqrt((Math.Pow(N, r.NextDouble())) / (Math.Pow(N + 1, r.NextDouble())));

                            for (int i = 0; i < M; i++)
                                for (int j = 0; j < N; j++)
                                    m[i, j] = Math.Sqrt((Math.Pow(N, r.NextDouble())) / (Math.Pow(N + 1, r.NextDouble())));

                            Console.Write("Одномерный массив: ");

                            for (int i = 0; i < N - 1; i++)
                                Console.Write($"{n[i]:F3}, ");
                            Console.Write($"{n[N - 1]:F3}.");

                            Console.WriteLine("\nДвумерный массив: ");

                            for (int i = 0; i < M; i++)
                            {
                                for (int j = 0; j < N - 1; j++)
                                    Console.Write($"{m[i, j]:F3}, ");
                                Console.Write($"{m[i, N - 1]:F3}.\n");
                            }

                            Console.WriteLine("№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№");
                            Console.ReadKey();
                        }
                        break;
                    }
                case "2":
                    {
                        var size = 1024;
                        var A = new double[size];
                        var B = new double[size];

                        int ai = 0, bi = 0;

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("№ Первым на печать вывести массив, сумма значений которого окажется наименьшей");
                            Console.WriteLine("№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№");
                            Console.WriteLine($"№ Введите одно значение для {ai + 1} элемента массива A и нажмите enter.");
                            Console.Write("№ (Для перехода к заполнению массива B ничего не вводите и нажмите enter): ");

                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            if (double.TryParse(input, out double elem))
                                A[ai++] = elem;
                            else
                            {
                                Console.WriteLine($"Ошибка! Вы ввели {input}, а нужно ввести число (можно с запятой).\nПопробуйте ещё раз (нажмите enter для продолжения).");
                                Console.ReadKey();
                                continue;
                            }
                        }

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("№ Первым на печать вывести массив, сумма значений которого окажется наименьшей");
                            Console.WriteLine("№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№");
                            Console.WriteLine($"№ Введите одно значение для {bi + 1} элемента массива B и нажмите enter.");
                            Console.Write($"№ (Для прекращения заполнения ничего не вводите и нажмите enter): ");

                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            if (double.TryParse(input, out double elem))
                                B[bi++] = elem;
                            else
                            {
                                Console.WriteLine($"Ошибка! Вы ввели {input}, а нужно ввести число (возможно, с запятой).\nПопробуйте ещё раз (нажмите enter для продолжения).");
                                Console.ReadKey();
                                continue;
                            }
                        }

                        double suma = 0, sumb = 0;

                        for (int i = 0; i < ai; i++)
                            suma += A[i];
                        for (int i = 0; i < bi; i++)
                            sumb += B[i];

                        if (suma < sumb)
                        {
                            Console.WriteLine("№ Сумма элементов массива А оказалась меньше!");
                            for (int i = 0; i < ai; i++)
                                Console.Write($"/{A[i]}\\ ");
                        } 
                        else if (suma > sumb)
                        {
                            Console.WriteLine("№ Сумма элементов массива B оказалась меньше!");
                            for (int i = 0; i < bi; i++)
                                Console.Write($"/{B[i]}\\ ");
                        }
                        else
                            Console.WriteLine("№ Суммы элементов обоих массивов оказались равны!");
                        Console.ReadKey();
                        break;
                    }
                case "3":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("№ Дан A(n,n), найти сумму всех его элементов, расположенных выше главной диагонали.");
                            Console.WriteLine("№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№");
                            Console.Write("№ Задайте n-размерность массива: ");
                            
                            input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            double[,] A;

                            if (int.TryParse(input, out int n))
                                A = new double[n, n];
                            else
                            {
                                Console.WriteLine($"Ошибка! Вы ввели {input}, а надо целое число! Попробуйте ещё раз (нажмите enter).");
                                Console.ReadKey();
                                continue;
                            }

                            Random r = new Random();

                            for (int i = 0; i < n; i++)
                                for (int j = 0; j < n; j++)
                                    A[i, j] = r.NextDouble();

                            Console.Write($"№ Заданный массив A {n} на {n}:\n№ ");

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n - 1; j++)
                                    Console.Write($" {A[i, j]:F3} | ");
                                Console.Write($"{A[i, n - 1]:F3}^\n№ ");
                            }

                            Console.Write("\n№ Сумма его элементов выше главной диагонали: ");
                            
                            double sum = 0;

                            for (int i = 0; i < n - 1; i++)
                                for (int j = i + 1; j < n; j++)
                                    sum += A[i, j];

                            Console.WriteLine($"{sum:F3}.");
                            Console.ReadKey();
                            break;
                        }
                        break;
                    }
                case "4":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("№ Сортировка элементов массива методом простого выбора.");
                            Console.WriteLine("№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№");
                            Console.Write("№ Введите размер для массива: ");

                            input = Console.ReadLine();
                            
                            if (string.IsNullOrWhiteSpace(input))
                                break;

                            int[] A;

                            if (int.TryParse(input, out int n))
                                A = new int[n];
                            else
                            {
                                Console.WriteLine($"Ошибка! Вы ввели {input}, а надо целое число! Попробуйте ещё раз (нажмите enter).");
                                Console.ReadKey();
                                continue;
                            }

                            Random r = new Random();

                            for (int i = 0; i < n; i++)
                                A[i] = r.Next(100);

                            Console.Write("№ Получившийся массив: ");

                            for (int i = 0; i < n - 1; i++)
                                Console.Write($"{A[i]}, ");
                            Console.Write($"{A[n - 1]}!\n");

                            Console.WriteLine("№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№");
                            Console.Write("№ Отсортированный    : ");

                            for (int i = 0; i < n - 1; i++)
                                for (int j = i + 1; j < n; j++)
                                    if (A[i] > A[j])
                                    {
                                        int temp = A[i];
                                        A[i] = A[j];
                                        A[j] = temp;
                                    }

                            for (int i = 0; i < n - 1; i++)
                                Console.Write($"{A[i]}, ");
                            
                            Console.Write($"{A[n - 1]}^");
                            Console.ReadKey();
                            break;
                        }
                        break;
                    }
                case "5":
                    Application.Run(new FormOf5());
                    break;
            }
        }
    }
}