void Hurd()
{
    Console.WriteLine("Введите числа: ");
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