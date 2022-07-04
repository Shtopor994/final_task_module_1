/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/


int n = InputNumbers("Введите количество строк массива: ");
string[] arrayOfStrings = new string[] { };
arrayOfStrings = new string[n];

for (int i = 0; i < arrayOfStrings.Length; i++)
{
    Console.Write($" Введите элементы {i + 1} строки: ");
    arrayOfStrings[i] = Console.ReadLine();
}

int lengthLimit = 3;
int numbersItems = CheckArray(arrayOfStrings, lengthLimit);
string[] newArrayOfStrings = new string[numbersItems];

FillArray(arrayOfStrings, newArrayOfStrings, lengthLimit);

Console.WriteLine($"{PrintArray(newArrayOfStrings)}");


void FillArray(string[] pastArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < pastArray.Length; i++)
    {
        if (pastArray[i].Length <= lengthLimit)
        {
            newArray[temp] = pastArray[i];
            temp++;
        }
    }
}

int CheckArray(string[] array, int lengthLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit) result++;
    }
    return result;
}

string PrintArray(string[] array)
{

    string result = string.Empty;
    result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += "]";
    return result;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
