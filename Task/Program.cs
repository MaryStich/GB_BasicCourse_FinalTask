// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System.Globalization;

string[] array1 = new string[4] { "Hello", "2", "world", ":-)" };
string[] array2 = new string[array1.Length];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SecondArray(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length<=3)
        {
            array2[j]=array1[i];
            j++;
        }
    }
}
SecondArray(array1, array2);
PrintArray(array2);