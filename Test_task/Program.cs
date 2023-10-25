// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] GetArray(int length = 1)
{
    string[] strs = new string[length];
    for (int i = 0; i < strs.Length; i++)
    {
        Console.Write("Введите строку {0}:\r\n    ", i + 1);
        strs[i] = Console.ReadLine();
    }
    return strs;
}

int ArraySize(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] NewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int idx = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[idx] = array[i];
            idx++;
        }
    }
    return newArray;
}


void PrintArray(string[] array)
{
    int count = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
            Console.Write(", ");
    }
    System.Console.WriteLine();
}


string[] array = GetArray();
Console.WriteLine("-->");
int size = ArraySize(array);
string[] newArray = NewArray(array, size);
PrintArray(newArray);
