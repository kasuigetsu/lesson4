using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine(GetFullName("Перфилов", "Юрий", "Аркадьевич") + "\n" + GetFullName("Билалетдинова", "Сабина", "Айратовна") + "\n" + GetFullName("Хайруллина", "Эльвира", "Наилевна"));
            Console.WriteLine();

            //Задание 2
            Console.Write("Введите набор чисел разделенных пробелом: ");
            string str = Console.ReadLine();
            string[] symbols = str.Split(' ');
            int sum = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                sum += Convert.ToInt32(symbols[i]);
            }
            Console.Write($"Сумма чисел = {sum}");
            Console.WriteLine("\n");


            //Задание 3
            string answer = GetMonthName();
            Console.WriteLine(answer);
            Console.WriteLine();

            //Задание 4
            Console.Write("Введите значение для вычисления числа Фиббоначчи: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            string num_value = (numb > 0) ? "Число Фиббоначчи для заданного значения = "+ Convert.ToString(ToGetFibbonachiNumValue(numb)) : "Ошибка: значение не может быть нулевым или отрицательным!";
            Console.WriteLine(num_value);

            Console.ReadKey();
        }
        static string GetFullName(string lastName,string firstName,string patronymic)//Метод к заданию 1: Вывод объединенной строки ФИО.
        {
            return $"Приветствую, {lastName+" "+firstName+" "+patronymic}!";
        }
        enum Season//Метод к заданию 3: Присвоение значений времени года.
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static string printSeason(Season num)//Метод к заданию 3: Присвоение читабельного значения времени года в зависимости от значения enum.
        {
            if(num==Season.Winter)
            {
                return "Зима";
            }
            else if(num == Season.Spring)
            {
                return "Весна";
            }
            else if(num==Season.Summer)
            {
                return "Лето";
            }
            else if(num==Season.Autumn)
            {
                return "Осень";
            }
            return String.Empty;
        }
        static string GetMonthName()//Метод к заданию 3: Вывод читабельного значения времени года в зависимости от введенного пользователем порядкового номера месяца.
        {
            Console.Write("Введите порядковый номер месяца: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num==1||num==2||num==12)
            {
               return "Время года: "+printSeason(Season.Winter);
            }
            else if(num>2&&num<6)
            {
                return "Время года: " + printSeason(Season.Spring);
            }
            else if(num>5 && num<9)
            {
               return "Время года: " + printSeason(Season.Summer);
            }
            else if(num>8&&num<12)
            {
                return "Время года: " + printSeason(Season.Autumn);
            }
            return "Ошибка: введите число от 1 до 12";
        }

        static int ToGetFibbonachiNumValue(int numb)//Метод к заданию 4: Нахождение числа Фиббоначчи.
        {
            int first = 0; int second = 1;
            int help; 
            int result = 0;
            if (numb == 1)
            {
                result = 0;
            }
            else if (numb == 2)
            {
                result = 1;
            }
            else
            {
                while (numb > 2)
                {
                    result = first + second;
                    help = first;
                    first = second;
                    second = result;
                    numb--;
                }
            }
            return result;
        }
    }
}
