// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] GetArray(int length = 1)
{
    // int n = 1;
    string[] strs = new string[length];
    for (int i = 0; i < strs.Length; i++)
    {
        Console.Write("Введите строку {0}:\r\n    ", i + 1);
        strs[i] = Console.ReadLine();
    }
    Console.WriteLine("Вы ввели следующие значения:");
    for (int i = 0; i < strs.Length; i++)
    {
        Console.WriteLine(strs[i]);
    }
    return strs;
}

string GetNewArray(string[] array)
{

}


string[] array = GetArray();