using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для перевода в двадцатеричную систему счисления");
            string a;
            a = Console.ReadLine();
            int b;
            b = Convert.ToInt32(a);
            string result = "";
            int t = 0;
            if (b > 0)
            {
                while (b >= (20-1))
                {
                    t = b % 20;
                    b = (b - t) / 20;
                    if (t < 10)
                    {
                        result = Convert.ToString(t) + result;
                    }
                    else
                    {
                        switch (t)
                        {
                            case 10:
                                result = "a" + result;
                                break;
                            case 11:
                                result = "b" + result;
                                break;
                            case 12:
                                result = "c" + result;
                                break;
                            case 13:
                                result = "d" + result;
                                break;
                            case 14:
                                result = "e" + result;
                                break;
                            case 15:
                                result = "f" + result;
                                break;
                            case 16:
                                result = "g" + result;
                                break;
                            case 17:
                                result = "h" + result;
                                break;
                            case 18:
                                result = "i" + result;
                                break;
                            case 19:
                                result = "j" + result;
                                break;
                            case 20:
                                result = "k" + result;
                                break;
                        }
                    }
                }
            }
            if (b < 10)
            {
                result = Convert.ToString(b) + result;
            }
            else
            {
                switch (b)
                {
                    case 10:
                        result = "a" + result;
                        break;
                    case 11:
                        result = "b" + result;
                        break;
                    case 12:
                        result = "c" + result;
                        break;
                    case 13:
                        result = "d" + result;
                        break;
                    case 14:
                        result = "e" + result;
                        break;
                    case 15:
                        result = "f" + result;
                        break;
                    case 16:
                        result = "g" + result;
                        break;
                    case 17:
                        result = "h" + result;
                        break;
                    case 18:
                        result = "i" + result;
                        break;
                    case 19:
                        result = "j" + result;
                        break;
                    case 20:
                        result = "k" + result;
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}