Console.Clear();
Console.WriteLine(string.Empty);
Console.WriteLine("Доброго времени суток!");
Console.WriteLine(string.Empty);
Console.WriteLine("Я - программа, создающая массив из строк введенных вами");
Console.WriteLine("и создающая из них новый массив из строк не более 3-х символов!");
Console.WriteLine("Вводите строки вашего массива по очереди через 'Enter'");
Console.WriteLine("Введите слово 'quit' для завершения работы и вывода результата");

string [] arr1 = new string[10000];
int check = 0;
while (true)
{
    string line = Console.ReadLine();
    int i = 0;
    if (line == "quit")
    {
        Console.WriteLine(string.Empty);
        Console.WriteLine("Спасибо! Ваш новый массив готов!");
        check = 1;
        break;
    }
    else
    {
        arr1[i] = line;
        i++;
    }

}

if (check == 1)
{
    Console.WriteLine("suck dick!!");
}