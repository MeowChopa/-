using System;
namespace FourthLan
{
    internal class Lab() {

        //первое задание
        public static void Massives()
        {
            int max = int.MinValue;
            int[] Number = new int[5];
            for (int i = 0; i < Number.Length; i++)
            {
                //выгу выгу выгу
                do
                {
                    Console.Write("Введите число для массива с индексом " + i + ": ");
                    string? str = Console.ReadLine();

                    if (!int.TryParse(str, out Number[i]))
                    {
                        Console.WriteLine("Некорректный ввод данных, ожидалось целое число");
                    }

                    else { break; }
                } while (true);

                for (int j = 0; j < Number.Length; j++)
                {
                    //сравниваю элементы массива, если элемент больше переменной максимума, то его значение присваивается максимуму
                    if (Number[j] > max)
                    {
                        max = Number[j];
                    }

                }
            }
            Console.WriteLine("Наибольшим числом массива является: " + max + "\n");
        }
        
        //второе задание
        public static void The_vowel_letter() {
            Console.Write("Введите строку: ");
            string? str = Console.ReadLine();
            char[] chr = new char[str.Length];
            for (int j = 0; j < chr.Length; j++)
            {
                chr[j] = str.ToLowerInvariant().ToCharArray()[j];

                switch (chr[j])
                {
                    //английские гласные
                    case 'a':
                    case 'e':
                    case 'y':
                    case 'i':
                    case 'u':
                    case 'o':
                        Console.Write(chr[j]);
                        break;

                    //точно также для русских гласных 
                    case 'а':
                    case 'о':
                    case 'у':
                    case 'э':
                    case 'ы':
                    case 'я':
                    case 'е':
                    case 'ё':
                    case 'ю':
                    case 'и':
                        Console.Write(chr[j]);
                        break;
                    default: break;
                }
            }
            Console.WriteLine("\n");
        }
        //третье задание
        public static void Min_of_massive(){

            int[] mass = new int[10];
            int min = int.MaxValue;
            for (int i = 0; i < mass.Length; i++)
            {
                do
                {
                    Console.Write("Введите число для массива с индексом " + i + ": ");
                    string? str = Console.ReadLine();

                    if (!int.TryParse(str, out mass[i]))
                    {
                        Console.WriteLine("Некорректный ввод данных, ожидалось целое число");
                    }

                    else { break; }
                } while (true);  }
                
                for (int j = 0; j < mass.Length; j++){
                    if (min>Math.Abs(mass[j])){
                        min = Math.Abs(mass[j]);
                    }
                }
            Console.WriteLine("Наименьшим числом массива является: " + min);
        }
            

        public static void Main(string[] args)
        {
            Console.WriteLine("Лабараторная №4 \n" +
             "Вариант 1\n" +
              "1.Создайте целочисленный массив длиной пять элементов.\n" +
               "Массив заполняет пользователь.\n" +
               "Вывести в консоль индекс самого большого элемента массива.");
            Massives();

            Console.WriteLine("2.Пользователь вводит строку.\n" +
               "Вывести в консоль только гласные буквы этой строки.");
            The_vowel_letter();

            Console.WriteLine("3.Создайте целочисленный массив длиной десять элементов.\n" +
            "Массив заполняет пользователь.\n" +
            "Вывести в консоль наименьшее значение массива по модулю.");
            Min_of_massive();
        }
    }


}
