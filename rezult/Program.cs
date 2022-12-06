// написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа 


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

string[] array = { "apple", "avocado", "fig", "kiwi", "156", "omg", "010", "111", "12" };
string[] newArray = new string[array.Length];

int j = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }

Array.Resize(ref newArray, j);
Console.Write("Изначальный массив строк: ");
PrintArray(array);
Console.WriteLine();
Console.Write("Новый массив элементов, которые содержат в себе 3 или менее символа: ");
PrintArray(newArray);