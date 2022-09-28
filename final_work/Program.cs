Console.Write("Введите n(колличество строк в массиве): ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

FillArray(array);
PrintArray(array);

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        arr[i] = Console.ReadLine();
    }
}

void PrintArray(string[] arr)
{
    Console.Write(string.Join(", ", array));
    Console.Write("=> [");

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3 && arr[i] != "")
        {
            Console.Write("\"{0}\",", arr[i]);
        }
    }
    Console.Write("]");
     Console.WriteLine();
}
