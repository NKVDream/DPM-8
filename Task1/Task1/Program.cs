using System;
using System.Text.RegularExpressions;
class Task1
{
    static void Main()
    {
        Console.Write("write down anything:");string X = Console.ReadLine();
        Check(X);
    }
    static bool Check(string X)
    {
        string Firstword = "English";
        int WordL = X.Length;
        int WordL2 = Firstword.Length;
        int AllWord = WordL - WordL2;
        if (AllWord < 0 ) return false;
        for (int i = 0; i <= X.Length - WordL2; i++)
        {
            // Проверяем, совпадает ли подстрока с targetWord
            bool match = true;
            for (int j = 0; j < WordL2; j++)
            {
                if (X[i + j] != Firstword[j])
                {
                    match = false;
                    break;
                }
            }
            string Fiend = "";
        }

    }
}