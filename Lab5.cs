namespace Lab5
{
    internal class Lab()
    {
        static int Partitioning(int[] arr, int low, int high) {
            int pivot = arr[high];
            int i = low-1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i = i+1;
                    int z = arr[i];
                    arr[i] = arr[j];
                    arr[j] = z;
                }
            }

            int b = arr[i+1];
            arr[i+1] = arr[high];
            arr[high] = b;

            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
            
            return i + 1;
            
 }
        public static void Quick_Sorting(int[] arr,int low, int high)
        {
            int pivot = 0;
            if (low < high)
            {
                pivot = Partitioning(arr, low, high);
                Console.WriteLine("");
                Quick_Sorting(arr, low, pivot - 1);
                Quick_Sorting(arr, pivot + 1, high);
            }
        }
        public static void Data(int n) {
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                do
                {
                    Console.Write("Введите значение элемента массива под индексов " + i + ": ");
                    string? str = Console.ReadLine();
                    if (!int.TryParse(str, out array[i]))
                    {
                        Console.WriteLine("Ожидалось целочисленное значение, введите целочисленное значение");
                    }
                    else { break; }
                } while (true);
            }
            Quick_Sorting(array, 0, array.Length - 1);
            
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("5-ая лабараторная работа.\n" +
            "Вариант 1\n" +
            "1.Создайте целочисленный массив array[n] и отсортируйте его методом “Quick Sorting”.\n Отсортированный массив вывести на экран.");
            int a = 0;
            do
            {
                Console.Write("Введите длинну массива: ");
                string? str = Console.ReadLine();
                if (!int.TryParse(str, out a))
                {
                    Console.WriteLine("Ожидалось целочисленное число");

                }
                else if (a <= 0)
                {
                    Console.WriteLine("ожидалась положительная длина массива");
                }
                else
                {
                    Data(a);
                    break;
                }
            } while (true);
          } 
    }
}