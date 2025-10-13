using System;
namespace TheFirstLab{
    internal class Lab(){
        static void FirstObjective()
        {
            //Первое задание
            Console.WriteLine("1.Уравнение движения материальной точки вдоль оси x имеет вид х=A+Bt+C(t^2).\n" +
                " A, B, C вводит пользователь.\n" +
                " Найти координату х, скорость v, ускорение a точки в момент времени t=4 с.");

            double V, a;
            double A = 0;
            Console.Write("Введите A: ");

            string? AA = Console.ReadLine();
            if (!double.TryParse(AA, out A))
            {
                Console.WriteLine("Ошибка ввода, необходимо ввести вещественное лицо.");
            }

            Console.Write("Введите B: ");
            double B = 0;
            string? BB = Console.ReadLine();
            
            if (!double.TryParse(BB, out B))
            {
                Console.WriteLine("Ошибка ввода, необходимо ввести вещественное лицо.");
            }
          

            Console.Write("Введите C: ");
            double C = 0;
            string? CC = Console.ReadLine();
            if (!double.TryParse(CC, out C))
            {
                Console.WriteLine("Ошибка ввода, необходимо ввести вещественное лицо.");
            }

            int Time = 4;
            double X = A + (B * Time) + (C * (Math.Pow(Time,2)));
            a = C * 2;
            V = B + a * Time;

            Console.WriteLine("X : " + X + " V : " + V + " a: " + a +"\n");
        } 
        static void SecondObjective()
        {
            //Второе задание
            Console.WriteLine("2.Написать программу вычисления стоимости разговора по телефону с учетом 20% скидки, предоставляемой по субботам и воскресеньям.\n" +
                " Ввести переменные для дня недели (целое), стоимости минуты разговора (вещественное), полной стоимости разговора.\n" +
                " Результат расчета вывести на экран.");
            double Sale = 0;
            double COST_PER_MINUTE = 0;
            int SECONDS_OF_DIALOGUE = 0;

            Console.Write("Введите индекс дня недели от 1 до 7: ");
            int DAY_OF_WEEK = 0;
            string? dow = Console.ReadLine();
            if (int.TryParse(dow, out DAY_OF_WEEK))
            {
                if (DAY_OF_WEEK < 1 | DAY_OF_WEEK > 7)
                {
                    Console.WriteLine("Некоторектный индекс дня недели");
                }
                else
                {
                    switch (DAY_OF_WEEK)
                    {
                        case 6: Sale = 0.2; break;
                        case 7: Sale = 0.2; break;
                        default:
                            Sale = 0;
                            break;
                    }
                    Console.Write("Введите стоимость минуты разговора по телефону: ");
                    string? cpm = Console.ReadLine();
                    if (!double.TryParse(cpm, out COST_PER_MINUTE))
                    {
                        Console.WriteLine("Ошибка ожидалось кол-во бананов(вещественное число).");
                    }

                    Console.Write("Введите длительность разговора в секундах: ");
                    string? sod = Console.ReadLine();
                    if (!int.TryParse(sod, out SECONDS_OF_DIALOGUE))
                    {
                        Console.WriteLine("Некорректно введённое время, ожидалось целочисленное значение");
                    }

                    double COST = SECONDS_OF_DIALOGUE * ((COST_PER_MINUTE / 60) * (1 - Sale));

                    Console.WriteLine("Стоимость разговора: " + COST + " бананов\n");
                }
            }
            else
            {
                Console.WriteLine("Ошибка, ожидалось целочисленное значение");
            }
        }
        static void ThirdObjective(){
            //Третье задание
            Console.WriteLine("3.Найти объём полу-шара с радиусом 10 м. \n" +
                " Результат вывести на консоль.");
            int Radius = 10;
            double Obiem_polu_shaharama = 0.5 * (4 * Math.PI * (Math.Pow(Radius,3)/3));
            Console.WriteLine("Объём полушара равен: " + Obiem_polu_shaharama + "\n");    
           
        }
         
        static void Main(string[] args) {

            //Вызов методов
            Console.WriteLine("Лаб.работа 1\n"+
            "Вариант 1 \n");
            FirstObjective();
            SecondObjective();
            ThirdObjective();

        }
    }
}

