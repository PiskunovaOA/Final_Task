// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите колличество элементов (слов, цифр) массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] ArrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    ArrayStrings[i] = element;
}

string[] GetLengthArray = new string[size];
int count = 0;
int arrayWords = 3;


for (int j = 0; j < size; j++)
{
    if (ArrayStrings[j].Length <= arrayWords)
    {
        GetLengthArray[count] = ArrayStrings[j];
        count++;
    }
}

Console.WriteLine();
PrintArray(GetLengthArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}