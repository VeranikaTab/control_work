// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void FillArray(string[] collection)
{
    int i = 0;
    while (i < collection.Length)
    {
        Console.Write("Введите элемент массива: ");
        collection[i] = Console.ReadLine();
        if (collection[i] == String.Empty || collection[i] == null)
        Console.WriteLine("Введите ненулевое значение!");
        else i++;
    }
}

void FindMassStringLessFour(string[] arr1, string[] result)
{
    int lengthStringMax = 3;
    int count = 0;
    
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= lengthStringMax)
        {
            result[count] = arr1[i];
            count++;
        }
    }
    if (count == 0) Console.WriteLine("Таких элементов нет");
}

Console.Write("Введите количество элементов массива:\t");
int size = int.Parse(Console.ReadLine());
string[] arr1 = new string[size];

int lengthStringMax = 3;
string[] result = new string[arr1.Length];
FillArray(arr1);
Console.WriteLine("Результат: ");
FindMassStringLessFour(arr1, result);
PrintArray(result);
