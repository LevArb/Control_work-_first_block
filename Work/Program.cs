Console.Clear();
Console.WriteLine(string.Empty);
Console.WriteLine("Доброго времени суток!");
Console.WriteLine(string.Empty);
Console.WriteLine("Я - программа, создающая массив из строк введенных вами");
Console.WriteLine("и создающая из них новый массив из строк не более 3-х символов!");
Console.WriteLine("Вводите строки вашего массива по очереди через 'Enter'");
Console.WriteLine("Введите слово 'quit' для завершения работы и вывода результата");
Console.WriteLine("");
string [] arr1 = new string[10000];
int check = 0;
int i = 0;
while (true)
{
    string line = Console.ReadLine();
    if (line == "quit")
    {
        Console.WriteLine(string.Empty);
        Console.WriteLine("Спасибо! Ваш новый массив готов!");
        Console.WriteLine("");
        check = 1;
        break;
    }
    else
    {
        arr1[i] = line;
        i++;
    }
}
string [] arr2 = new string[10000];
int j = 0;
try
{
    if (check == 1)
    {
        while (j < arr1.Length)
        {
            if (arr1[j].Length <= 3)
            {
                arr2[j] = arr1[j];
                Console.Write(arr2[j] + " ");
                j++;
            }
            else
            {
                j++;
            }
        }
    }
}
catch (System.NullReferenceException)
{
    Console.Write("");
}