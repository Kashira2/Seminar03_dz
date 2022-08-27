int Cube(int index)
{
    int cube = Convert.ToInt32(Math.Pow(index, 3));
    return cube;
}
    
    Console.WriteLine("Введите число");
    int num = int.Parse(Console.ReadLine());
    int ind = 1;
    while (ind <= num)
    {
        Console.WriteLine(Cube(ind));
        ind++;
    }