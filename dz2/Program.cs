string GetDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double firstDot = Math.Pow(x2-x1, 2);
    double secondDot = Math.Pow(y2-y1, 2);
    double thirdDot = Math.Pow(z2-z1, 2);
    double distance = Math.Sqrt(firstDot + secondDot + thirdDot);
    return $"{distance}";
}
Console.Write("Введите координаты первой точки в 3D пространстве: x = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты второй точки в 3D пространстве: x = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetDistance(x1,x2,y1,y2,z1,z2));

