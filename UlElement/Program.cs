using System;

namespace UlElement
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int valueHelthBar = 0, valueManaBar = 0;
                Console.Write("Введите на сколько % заполнена шкалы Healthbar ( не больше 100): ");
                valueHelthBar = int.Parse(Console.ReadLine());
                Console.Write("Введите на сколько % заполнена шкалы ManaBar ( не больше 100): ");
                valueManaBar = int.Parse(Console.ReadLine());
                if (valueHelthBar <= 100 && valueManaBar <= 100)
                {
                    Bar(valueHelthBar, ConsoleColor.Red);
                    Console.WriteLine();
                    Bar(valueManaBar, ConsoleColor.Blue);
                }
                else
                {
                    Console.WriteLine("Процент указан не верно! Попробуйте заного!");
                }
            }
        }
        static void Bar(int value, ConsoleColor color)
        {
            int maxValue = 50;
            value = value / 2;
                string bar = "";
                for (int i = 0; i < value; i++)
                {
                    bar += '#';
                }
                Console.Write("[");
                Console.BackgroundColor = color;
                Console.Write(bar);
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                bar = "";
                for (int i = value; i < maxValue; i++)
                {
                    bar += ' ';
                }
                Console.Write(bar);
                Console.ResetColor();
                Console.WriteLine("]");
        }
    }
}
//Задача:
//Разработайте функцию, которая рисует некий бар(Healthbar, Manabar)в определённой позиции. Она также принимает некий закрашенный процент.
//При 40% бар выглядит так:
//[####_____]