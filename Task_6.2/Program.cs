using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string text = Console.ReadLine(); //ввод предложения с клавиатуры
            string textLower = text.ToLower();//убираем регистр
            string textReplace = textLower.Replace(" ", ""); //убираем пробелы
            char[] sArrayOut = textReplace.ToCharArray(); //преобразуем строку в массив
            Array.Reverse(sArrayOut); //реверс массива
            string result = new string(sArrayOut); //генерируем новую строку

            bool check = String.Equals(textReplace, result); //проверяем условие на палиндром
            Console.WriteLine();
            if (check == true)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
                      
                Console.ReadKey();

        }
    }
}
