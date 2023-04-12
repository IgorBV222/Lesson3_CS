using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Forms;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //001 Прикрепите пример кода программы по следующему заданию.
            //Пользователь вводит 4 - хзначное число.Программа должна вывести полученное число в обратном порядке.
            /*
            Console.WriteLine("Введите 4-х значное число");
            string input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine(input[i]); // в столбик
                Console.Write(input[i] + " "); //в строку
            }
            Console.ReadKey();*/

            //002 Прикрепите пример кода программы по следующему заданию.
            //Пользователь вводит 6 - тизначное число.Программа должна вывести в столбик все чётные цифры этого числа.
            /*string input1;
            int tmp;
            //bool IsNotCorrect = false;
            Console.WriteLine("Введите 6-и значное число");
            input1 = Console.ReadLine();
            {
                try
                {
                    for (int i = 0; i < input1.Length; i++)
                    {
                        tmp = int.Parse(input1[i].ToString()); // tmp = (int)input1[i]; -не хороший вариант
                        if (tmp % 2 == 0)
                        {
                            Console.WriteLine(tmp);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ввод некорректен!");
                }
            }
            Console.ReadKey();*/

            //003 Прикрепите пример кода программы по следующему заданию.
            //Программа должна позволять считать время, за которое спортсмен пробегает круг.
            //Для старта измерений использовать клавиша "Enter", получение отметки пройденного круга -"Enter",
            //конец забега и вывод результатов - клавиша "Пробел".
            //Работа со временем

            /*DateTime startTime = DateTime.Now;
            Console.WriteLine(startTime.ToString("yyyy.MM.dd HH.m.s.ffffff"));
            Console.ReadKey();
            DateTime stopTime = DateTime.Now;
            TimeSpan timeSpan = stopTime - startTime;
            Console.WriteLine($"\nПрошло {timeSpan.ToString("ss")} секунд и {timeSpan.ToString("fff")} миллисекунд");
            Console.ReadKey();
            //Распознование клавиш
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int keyCode = (int)key;
                Console.WriteLine($"\t Enum {key}\tKey code {keyCode}");
            }*/

            //004 Прикрепите пример кода программы по следующему заданию.
            //Пользователю предлагается ввести данные показаний счётчика для горячей(ГВС) и холодной(ХВС) 
            //воды в формате 8 - мизначных чисел по месяцам от января до декабря.
            //Программа должна контролировать техническую корректность ввода данных(не давать вводить строку вместо числа), 
            //логическую корректность(показания следующего месяца не должны быть меньше показаний предыдущего) и иметь 
            //обявленную клавишу выхода из процедуры ввода.
            //Завершение ввода программы - вывод таблицвы потребления по месяцам и суммируюущую строку за год.

            //005 Запись в файл
            
            var path = Environment.GetFolderPath
                (Environment.SpecialFolder.MyDocuments);
            DateTime dt = DateTime.Now;
            path += "\\" + dt.ToString("HHmmss")+ "file.txt";
            Console.WriteLine(path);
            var streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("TEST");
            streamWriter.Close();

            var streamReader = new StreamReader(path);
            Console.WriteLine(streamReader.ReadLine());
            streamReader.Close();
            Console.ReadKey();



        }
    }
}