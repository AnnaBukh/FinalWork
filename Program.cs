string[] CreateArray (int size)
{
    Console.WriteLine("Введите элементы массива: ");
    string[] array1 = new string[size];
       for (int i = 0; i < array1.Length; i++)
   {
    array1[i] = Convert.ToString(Console.ReadLine());
   }
   return array1;
} 

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] arr1 = CreateArray(5);
Console.WriteLine("Исходный массив: ");
PrintArray(arr1);

string[] FindElementsArray(string[] array1)
{
    int ind2 = 0;
    string[] array2 = new string[array1.Length];
    for (int ind1 = 0; ind1 < array1.Length; ind1++)
    {
        if (array1[ind1].Length <= 3)
            {array2[ind2] = array1[ind1];
            ind2++;
            }
    }
   return array2;
} 
string[] arr2 = FindElementsArray(arr1);
Console.WriteLine("Массив с элементами из строк, длина которых меньше либо равна 3м символам: ");
PrintArray(arr2);
