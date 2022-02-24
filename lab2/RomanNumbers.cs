using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
     class RomanNumber : ICloneable, IComparable
    {

        private ushort number_to_calc;
        private static int[] numbers = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        private static string[] roman_string = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        //Конструктор получает представление числа n в римской записи
        public RomanNumber(ushort n)
        {
            if (n <= 0) throw new RomanNumberException($"{n} <= либо равно 0");
            else this.number_to_calc = n;
        }
        //Сложение римских чисел
        public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1.number_to_calc + n2.number_to_calc;
            if (num <= 0) throw new RomanNumberException("Ошибка! Сумма <= 0");
            else
            {
                RomanNumber result = new((ushort)num);
                return result;
            }
        }
        //Вычитание римских чисел
        public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
        {
            int num = n1.number_to_calc - n2.number_to_calc;
            if (num <= 0) throw new RomanNumberException("Ошибка! Разность <= 0");
            else
            {
                RomanNumber result = new((ushort)num);
                return result;
            }
        }
        //Умножение римских чисел
        public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
        {
            int number = n1.number_to_calc * n2.number_to_calc;
            if (number <= 0) throw new RomanNumberException("Ошибка! Резльтат умножения <= 0");
            else
            {
                RomanNumber result = new((ushort)number);
                return result;
            }
        }
        //Целочисленное деление римских чисел
        public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
        {

            if (n2.number_to_calc == 0) throw new RomanNumberException("Ошибка! Делитеь равен нулю");
            else
            {
                int num = n1.number_to_calc / n2.number_to_calc;
                if (num <= 0) throw new RomanNumberException("Ошибка! Результат деления <= 0");
                else
                {
                    RomanNumber result = new((ushort)num);
                    return result;
                }
            }
        }
        //Возвращает строковое представление римского числа
        public override string ToString()
        {
            int tmp = number_to_calc;
            StringBuilder result = new StringBuilder();
            for (int item = 12; item >= 0; item--)
            {
                while (tmp >= numbers[item])
                {
                    tmp -= numbers[item];
                    result.Append(roman_string[item]);
                }
            }
            if (result.ToString() == "")
                throw new RomanNumberException("Ошибка! Перевод чисел невозможен");
            else
                return result.ToString();

        }

        public object Clone()
        {
            return new RomanNumber(number_to_calc);
        }

        public int CompareTo(object obj)
        {
            if (obj is RomanNumber roman)
                return number_to_calc.CompareTo(roman.number_to_calc);
            else
                throw new RomanNumberException("Ошибка! Сравнение не удалось");
        }

    }

}