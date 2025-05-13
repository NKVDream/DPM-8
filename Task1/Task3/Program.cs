using System;
class Task3
{
    static void Main()
    {
        Console.Write("Write down any word: ");
        string Y = Console.ReadLine();
        string result = Task3.Del(Y, out string resY);
        Console.Write(result);
    }
    static string Del(string y, out string resY)
    {
        int StrL = y.Length;
        string NewYu = "";
        string NewYl = "";
        for (int i = 0; i < StrL; i++)
        {
            if (i %2 == 0)
            {
                NewYu += y.ToUpper()[i];
                continue;
            }
            else if ((StrL - 1) %2 != 0)
            {
                NewYu += y.ToLower()[i];
            }
        }
        for (int i = 0; i < StrL; i++)
        {
            if (i % 2 == 0)
            {
                NewYl += y.ToLower()[i];
                continue;
            }
            else if ((StrL - 1) % 2 != 0)
            {
                NewYl += y.ToUpper()[i];
            }
        }
        resY = ($"'{y}'->'{NewYu}','{NewYl}'");
        return resY;


    }
}
