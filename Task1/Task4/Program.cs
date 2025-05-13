using System;

class Task4
{
    static void Main()
    {
        Console.Write("Write down a polindrom: ");
        string P = Console.ReadLine();
        bool result = Task4.Poli(P, out bool Pres);
        Console.WriteLine(result);
    }

    static bool Poli(string p, out bool Pres)
    {

        int length = p.Length;
        int FPLH = length / 2;
        string SubP1 = p.Substring(0, FPLH);
        string SubP2 = p.Substring(length - FPLH);

        char[] charArray = SubP2.ToCharArray();
        Array.Reverse(charArray);
        string reversedSubP2 = new string(charArray);

        if (SubP1 == reversedSubP2)
        {
            Console.WriteLine("It's a palindrome");
            Pres = true;
            return Pres;
        }
        else
        {
            Console.WriteLine("It's not a palindrome");
            Pres = false;
            return Pres;
        }
    }
}
