using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] array = { -7,10,5,16,-4,18};
            //for(int i = array.Length-1; i>=0; i--)
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //Задание 2. Заполнить ОМ случайным образом, подсчитать колл-во отриц. элементов
            //Console.Write("n=");
            //byte n = Convert.ToByte(Console.ReadLine());
            //int[] array = new int[n];
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(-10, 10);
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //byte count = 0;
            ////for (int i = 0; i < array.Length; i++)
            ////{
            ////    if (array[i] < 0) count++;
            ////}
            //foreach (int elem in array)
            //{
            //    if (elem < 0) count++;
            //}
            //Console.WriteLine($"Колл-во отрицательных элементов = {count}");
            //Задача 3. В ОМ значения всех элементов увеличить в два раза
            int[] array = { -5, 5, -6, 6, -7, 7 };
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * 2; //array[i]*=2;
                Console.Write($"{array[i]}\t");
            }
            //foreach (int elem in array)
            //{
            //    Console.Write($"{elem}\t");
            //}
        }
    }
}
