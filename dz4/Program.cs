void Hurd()
{
    Console.WriteLine("Введите семь чисел: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a + b == 0)
    {
        Console.WriteLine($"{a*a+b*b}");
    }
    else
    {
        int ab = a+b;
        int c = Convert.ToInt32(Console.ReadLine());
        if (ab + c == 0)
        {
        Console.WriteLine($"{a*a+b*b+c*c}");
        }
        else
        {
            int abc = ab + c;
            int d = Convert.ToInt32(Console.ReadLine());
            if (abc + d == 0)
            {
            Console.WriteLine($"{a*a+b*b+c*c+d*d}");
            }
            else 
            {   
                int abcd = abc + d; 
                int e = Convert.ToInt32(Console.ReadLine());
                if (abcd + e == 0)
                {
                Console.WriteLine($"{a*a+b*b+c*c+d*d+e*e}");
                }
                else
                {
                    int abcde = abcd + e;
                    int f = Convert.ToInt32(Console.ReadLine());
                    if (abcde + f == 0)
                    {
                    Console.WriteLine($"{a*a+b*b+c*c+d*d+e*e+f*f}");
                    }
                    else
                    {    
                        int abcdef = abcde + f;
                        int g = Convert.ToInt32(Console.ReadLine());
                        if (abcdef + g == 0)
                        {
                        Console.WriteLine($"{a*a+b*b+c*c+d*d+e*e+f*f+g*g}");
                        }
                        else
                        {  
                            int abcdefg = abcdef + g;
                            int h = Convert.ToInt32(Console.ReadLine());
                            if (abcdef + h == 0)
                            {
                            Console.WriteLine($"{a*a+b*b+c*c+d*d+e*e+f*f+g*g+h*h}");
                            }
                        }   
                    }                
                }
            }
        }
    }
}


Hurd();

/*
void SumNum1(int a, int b)
{
    if (a + b == 0)
    {
         Console.WriteLine($"{a*a+b*b}");
    }
}
void SumNum2(int a, int b, int c)
{
    if (a+ b + c == 0)
        {
        Console.WriteLine($"{a*a+b*b+c*c}");
        }
}
void SumNum3(int a, int b, int c, int d)
{
        if (a + b + c + d == 0)
        {
        Console.WriteLine($"{a*a+b*b+c*c+d*d}");
        }
}
void SumNum4(int a, int b, int c, int d, int e)
{
        if (a + b + c + d + e == 0)
        {
        Console.WriteLine($"{a*a+b*b+c*c+d*d+e*e}");
        }
}
void SumNum5(int a, int b, int c, int d, int e, int f)
{
        if (a + b + c + d + e + f == 0)
        {
        Console.WriteLine($"{a*a+b*b+c*c+d*d+e*e+f*f}");
        }
}
void SumNum6(int a, int b, int c, int d, int e, int f, int g)
{
        if (a + b + c + d + e + f + g== 0)
        {
        Console.WriteLine($"{a*a+b*b+c*c+d*d+e*e+f*f+g*g}");
        }
}
void SumNum7(int a, int b, int c, int d, int e, int f, int g, int h)
{
        if (a + b + c + d + e + f + g + h == 0)
        {
        Console.WriteLine($"{a*a+b*b+c*c+d*d+e*e+f*f+g*g+h*h}");
        }
}

Console.WriteLine("Введите семь чисел: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
SumNum1(a, b);
int c = Convert.ToInt32(Console.ReadLine());
SumNum2(a, b, c);
int d = Convert.ToInt32(Console.ReadLine());
SumNum3(a, b, c, d);
int e = Convert.ToInt32(Console.ReadLine());
SumNum4(a, b, c, d, e);
int f = Convert.ToInt32(Console.ReadLine());
SumNum5(a, b, c, d, e, f);
int g = Convert.ToInt32(Console.ReadLine());
SumNum6(a, b, c, d, e, f, g);
int h = Convert.ToInt32(Console.ReadLine());
SumNum7(a, b, c, d, e, f, g, h);
*/