using System;
class Task2
{
    static void Main()
    {
        Console.Write("Num to bin: ");int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Task2.toBin(n));
        int binNum = Task2.toBin(n);
        Console.WriteLine(Task2.Check(binNum, out bool result));
    }
    static int toBin(int n)
    {
        int res = 0;
        int p = 1;
        while (n > 0)
        {
            res += p * (n % 2);
            n >>= 1; // то же самое что n /= 2;
            p *= 10;
        }
        return res;
    }
    static bool Check(int b, out bool result)
    {
        int count = 0;
        while (b > 0)
        {
            if (b % 10 == 1)
            {
                count++;
            }
            b /= 10;
        }
        if (count % 2 == 0)
        {
            Console.WriteLine("its an evil number!");
            return result = true;
        }
        else { Console.WriteLine("its an odious number"); 
        return result = false;}
    }
}