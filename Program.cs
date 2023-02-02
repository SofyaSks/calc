using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            WriteLine("Калькулятор");
            string n, m;
            WriteLine("Введите первое число: ");
            n = ReadLine();
            WriteLine("Введите второе число: ");
            m = ReadLine();
            int nn = Convert.ToInt32(n);
            int mm = Convert.ToInt32(m);

            WriteLine("Выберите операцию: ");
            WriteLine("1 - сложение");
            WriteLine("2 - вычетание");
            WriteLine("3 - умножение");
            WriteLine("4 - деление");

            string choice;
            choice = ReadLine();
            int ch = Convert.ToInt32(choice);

            switch (ch)
            {
                case 1: 
                    WriteLine(nn + " + " + mm + " = " + (nn + mm));
                    break;
                case 2:
                    WriteLine(nn + " - " + mm + " = " + (nn - mm));
                    break;
                case 3:
                    WriteLine(nn + " * " + mm + " = " + (nn * mm));
                    break;
                case 4:
                    decimal nnd = Convert.ToDecimal(nn);
                    decimal mmd = Convert.ToDecimal(mm);
                    WriteLine(nn + " / " + mm + " = " + (nnd / mmd));
                    break;
                default:
                    WriteLine("такой операции не существует!");
                    break;
            }
        }
    }
}
