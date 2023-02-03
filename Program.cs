using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("выбор действия - сложение=0, вычитание=1, умножение=2, деление=3");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "0":
                        Console.Write("ввод первого значения=");
                        double value_1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("ввод второго значения=");
                        double value_2 = Convert.ToDouble(Console.ReadLine());
                        double result = value_1 + value_2;
                        Console.WriteLine(result);
                        break;
                    case "1":
                        Console.Write("ввод первого значения=");
                        value_1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("ввод второго значения=");
                        value_2 = Convert.ToDouble(Console.ReadLine());
                        result = value_1 - value_2;
                        Console.WriteLine(result);
                        break;
                    case "2":
                        Console.Write("ввод первого значения=");
                        value_1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("ввод второго значения=");
                        value_2 = Convert.ToDouble(Console.ReadLine());
                        result = value_1 * value_2;
                        Console.WriteLine(result);
                        break;
                    case "3":
                        Console.Write("ввод первого значения=");
                        value_1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("ввод второго значения=");
                        value_2 = Convert.ToDouble(Console.ReadLine());
                        if (value_2 == 0) Console.WriteLine("ошибка");
                        result = value_1 / value_2;
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("ошибка");
                        break;
                }
            } while (true);
        }
    }
}
