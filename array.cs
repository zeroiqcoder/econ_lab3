using System.Diagnostics;

namespace lab5_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();

            string operation;
            Console.WriteLine("Введите тип операции: +, -, *, /");
            while (true)
            {
                try
                {
                    operation = Console.ReadLine();
                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                        break;
                    else
                        Console.WriteLine("Нужно ввести +, -, * или /");
                }
                catch
                {
                    //Console.WriteLine("Ввод выполнен некорректно");
                }
            }
            //Console.WriteLine("Введите длину массива");
            string arr_length_input;
            while (true)
            {
                try
                {
                    arr_length_input = Console.ReadLine();
                    break;
                }
                catch
                {
                    //Console.WriteLine("Ввод выполнен некорректно, необходимо ввести целое число больше 0");
                }
            }
            //Console.WriteLine("Введите номер типа данных в массиве");
            //Console.WriteLine("1. Целые числа");
            //Console.WriteLine("2. Дробные числа");
            string type_input;
            while (true)
            {
                try
                {
                    type_input = Console.ReadLine();
                    if (type_input == "1" || type_input == "2")
                        break;
                    else
                        //Console.WriteLine("Нужно выбрать 1 или 2");
                }
                catch
                {
                    //Console.WriteLine("Некорректный ввод");
                }
            }
            //Console.WriteLine("Введите сначала минимальное число для генератора случайных чисел, а затем - максимальное");
            string rand_min;
            while (true)
            {
                try
                {
                    rand_min = Console.ReadLine();
                    double rand_min_num = Convert.ToDouble(rand_min);
                    break;
                }
                catch
                {
                    //Console.WriteLine("Ввод выполнен некорректно, необходимо ввести число");
                }
            }
            string rand_max;
            while (true)
            {
                try
                {
                    rand_max = Console.ReadLine();
                    double rand_max_num = Convert.ToDouble(rand_max);
                    double rand_min_num = Convert.ToDouble(rand_min);
                    long rand_min_int = Convert.ToInt64(rand_min_num);
                    long rand_max_int = Convert.ToInt64(rand_max_num);
                    if (rand_min_int < rand_max_int)
                        break;
                    else
                        //Console.WriteLine("Максимальное число должно быть больше минимального");
                }
                catch
                {
                    //Console.WriteLine("Ввод выполнен некорректно, необходимо ввести число");
                }
            }
            ulong arr_length = Convert.ToUInt64(arr_length_input);
            try
            {
                if (type_input == "2")
                {
                    double[] nums_array = new double[arr_length];
                    timer.Start();
                    Random random = new Random();
                    for (ulong i = 0; i < arr_length; i++)
                    {
                        nums_array[i] = random.NextDouble();
                    }
                    timer.Stop();
                    TimeSpan GenerationTime = timer.Elapsed;
                    //Console.WriteLine($"Время, затраченное на генерацию элементами массива: {GenerationTime}");

                    timer.Start();

                    if (operation == "+")
                    {
                        decimal sum = 0;
                        timer.Start();
                        foreach (decimal ch in nums_array)
                        {
                            sum += ch;
                        }
                        //Console.WriteLine($"Сумма: {sum}");
                    }
                    else if (operation == "-")
                    {
                        decimal diff = 0;
                        timer.Start();
                        foreach (decimal ch in nums_array)
                        {
                            diff -= ch;
                        }
                        //Console.WriteLine($"Разность: {diff}");
                    }
                    else if (operation == "*")
                    {
                        decimal prod = 1;
                        timer.Start();
                        foreach (decimal ch in nums_array)
                        {
                            if (ch != 0)
                                prod *= ch;
                            else
                                continue;
                        }
                        //Console.WriteLine($"Произведение: {prod}");
                    }
                    else if (operation == "/")
                    {
                        decimal quo = 1;
                        timer.Start();
                        foreach (decimal ch in nums_array)
                        {
                            if (ch != 0)
                                quo /= ch;
                            else
                                continue;
                        }
                        //Console.WriteLine($"Частное: {quo}");
                    }
                    timer.Stop();
                    TimeSpan OperationsTime = timer.Elapsed;
                    //Console.WriteLine($"Время, затраченное на операции с элементами массива: {OperationsTime}");
                }
                else if (type_input == "1")
                {

                }
            }
            catch
            {
                //Console.WriteLine("Недопустимая длина массива");
            }
        }
    }
}