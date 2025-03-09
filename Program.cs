/*Дан целочисленный одномерный массив. Напишите программу для поиска максимального элемента в массиве, кратного четырём.
Примечание. В данной задаче в тестах ВСЕГДА есть нужный элемент.*/
using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine()); // сколько чисел будут вводиться на следующей строке
        string s = Console.ReadLine(); // сохранить все введенную строку
        string[] ss = s.Split(' '); // разделить введенную строку по пробелам и сохранить в массив строкового типа
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            int number = Convert.ToInt32(ss[i]);
            numbers[i] = number;
        }
        int maxElement = -1;
        foreach (int num in numbers)
        {
            if (num % 4 == 0 && num > maxElement)
                maxElement = num;
        }
        Console.WriteLine(maxElement);
    }
}