bool IsWork = true;

while (IsWork)

{
    Console.WriteLine();
    Console.WriteLine("Выберите программу:");
    Console.WriteLine("1 - Программа считает сколько чисел больше ноля ввёл пользователь");
    Console.WriteLine("2 - Программа находит точку пересечения двух прямых");
    Console.WriteLine("-1 - Для завершения работы");
    Console.Write("Выберите номер программы: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
                {
                    Task_1();

                    void Task_1()
                    {
                        Console.WriteLine("----------");
                        int Arg = ReadInt("Сколько чисел хотите ввести? ");
                        Console.WriteLine();
                        GetPositiveNumbers(Arg);

                        int ReadInt(string argument)
                        {
                            Console.Write($"{argument}");
                            int number;

                            while (!int.TryParse(Console.ReadLine(), out number))
                            {
                                Console.WriteLine("вы ввели не число");
                            }

                            return number;
                        }

                        void GetPositiveNumbers(int arg)
                        {
                            int counter = 0;
                            for (int i = 1; i <= arg; i++)
                            {
                                int temp = ReadInt($"Введите {i}-е число: ");
                                if (temp > 0)
                                {
                                    counter++;
                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine($"Чисел больше 0: {counter}");
                        }
                    }
                    break;
                }
            case 2:
                {
                    Task_2();

                    void Task_2()
                    {
                        Console.WriteLine("----------");
                        GetPoint(ReadDouble("b1: "), ReadDouble("k1: "), ReadDouble("b2: "), ReadDouble("k2: "));

                        double ReadDouble(string argument)
                        {
                            Console.Write($"Введите {argument}");
                            double number;

                            while (!double.TryParse(Console.ReadLine(), out number))
                            {
                                Console.WriteLine("вы ввели не число");
                            }

                            return number;
                        }

                        void GetPoint(double b1, double k1, double b2, double k2)
                        {
                            double x = -(b2 - b1) / (k2 - k1);
                            double y1 = k1 * x + b1;
                            double y2 = k2 * x + b2;

                            Console.WriteLine();
                            Console.WriteLine($"Точка пересечения двух прямых: ({y1};{y2})");
                        }
                    }
                    break;
                }

            case -1: IsWork = false; break;
        }
    }
}