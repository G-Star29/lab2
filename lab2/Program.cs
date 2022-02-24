using System;
using System.Collections.Generic;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
          
                RomanNumber number_1 = new RomanNumber(81);
                RomanNumber number_2 = new RomanNumber(9);
                RomanNumber number_3 = new RomanNumber(26);
                RomanNumber[] numbers = { number_1, number_3, number_3 };
                Console.WriteLine($"Сложение: {number_1} + {number_3} = {RomanNumber.Add(number_1, number_3).ToString()}");
                Console.WriteLine($"Деление: {number_1} / {number_2} = {RomanNumber.Div(number_1, number_2).ToString()}");
                Console.WriteLine($"Вычитание: {number_1} - {number_3} = {RomanNumber.Sub(number_1, number_3).ToString()}");
                Console.WriteLine($"Умножение: {number_2} * {number_3} = {RomanNumber.Mul(number_2, number_3).ToString()}");
   
                Console.WriteLine("Сортировка массива: Исходные данные");
                foreach (var i in numbers)
                {
                    Console.WriteLine(i.ToString());
                }
                Array.Sort(numbers);
                Console.WriteLine("Сортировка массива: Выходные данные");
                foreach (var i in numbers)
                {
                    Console.WriteLine(i.ToString());
                }
        }
    }
}