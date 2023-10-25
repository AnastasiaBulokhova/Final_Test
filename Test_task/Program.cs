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

string[] newArray = new string[lenNewArray];
int idx = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}





string[] array = GetArray();
Console.WriteLine("->");

