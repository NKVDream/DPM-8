using System;
class Task1
{
    static void Main()
    {
        Console.Write("write down anything:");string X = Console.ReadLine();
        Task1.check(X);
    }
    static bool check(string X)
    {
        string Firstword = "English";
        string Fiend = "";
        for (int i = 0; i < X.Length; i++)
        {
            Console.Write(X[i]);
            if (X[i] == 'E')
            {
                Fiend += X[i];
                continue;
            }
            if (X[i] == 'n')
            {
                Fiend += X[i];
                continue;
            }
            if (Fiend = "En")
            {
                return true;
            }
        }
    }
}