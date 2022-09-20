// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше либо равна 3 символам.
System.Console.Write("Введите размер массива :");
int s = Convert.ToInt32(Console.ReadLine());
//string[] array =  {"hello","2","world",":-)"}
string[] FillArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"Введите {i+1}е значение");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[]MinimalArray (string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<=3) count++;
    }
    string[] res = new string[count];
    count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length<=3)
        {
            res[count] = arr[j];
            count++;
        }
    }
    return res;
}
void PrintArray(string[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i < arr.Length - 1) Console.Write($"'{arr[i]}', ");
       else Console.WriteLine($"'{arr[i]}']");
    }
}
string[] array =  FillArray(s);
System.Console.Write("Исходный массив :");
PrintArray(array);
string[] max3array = MinimalArray(array);
System.Console.Write("Этот же массив, но только со стоками не больше 3х символов :");
PrintArray(max3array);