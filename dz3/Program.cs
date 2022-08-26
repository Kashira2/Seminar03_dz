void Cube(int num)
{
    for (int index = 1; index <= num; index++)
    {
        Console.Write($"{index * index * index}, ");
    }

}
    Console.WriteLine("Введите число");
    int N =int.Parse(Console.ReadLine());
    Cube(N);