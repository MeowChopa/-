using System;
namespace SecondLab{
    internal class Lab(){
       public static double Square(double Number){
            return Math.Pow(Number,2);
        }

       public static string OutText() {
            return "C# forever \n" + ""; 
        }
       public static double AreaСalculation(double n, double N){
            return (n * N)/2;
        }

        static void Main(string[] args) {

            //первое задание
            Console.Write("Вариант 1. \n" +
                "1.Напишите функцию,\n" +
                "которая принимает как аргумент число и возвращает это число в квадрате,\n" +
                "результат выведите в консоль.\n" +
                "Напишите возвращаемое число: ");

            string? n = Console.ReadLine();
            double Num = 0;
            if (double.TryParse(n, out Num))
            {
                Console.WriteLine("Квадрат числа: " + Square(Num) + "\n" + "");
            } else { Console.WriteLine("Некорректный символ, введите вещественное число\n"); }


            //второе задание
            Console.WriteLine("2.Напишите функцию, которая выводит “С# forever”.\n" + "Результат вывести в консоль.");
            Console.WriteLine(OutText());

            //третие задание
            Console.Write("3.Напишите функцию, которая принимает в качестве аргумента длины катетов прямоугольного треугольника n и N \n" +
                "и рассчитывает площадь этого треугольника.\n" +
                "Результат вывести в консоль.\n" +
                "Введите первый катит: ");

            string? a_str = Console.ReadLine();
            double a = 0;
            if (double.TryParse(a_str, out a))
            {
            Console.Write("Введите второй катит: ");
                string? b_str = Console.ReadLine();
                double b = 0;
                if (double.TryParse(b_str, out b))
                {
                    Console.WriteLine("Площадь прямоугольного треугольника равна: " + AreaСalculation(a, b));
                } else{Console.WriteLine("Некорректный символ, введите вещественное число");}
            } else{Console.WriteLine("Некорректный символ, введите вещественное число");}
        }
    }
}
