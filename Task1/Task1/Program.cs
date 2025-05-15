using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
class Task1
{
    static void Main()
    {
        Console.Write("Write down a line: ");
        string Line = Console.ReadLine();
        bool result;
        Task1.Checking(Line, out result);
        Console.WriteLine(result);
    }
    static bool Checking(string line, out bool result)
    {
        result = Regex.IsMatch(line, "English");
        if (result)
        {
            result = true;
            return true;
        }
        else
        {
            return false;
        }
    }
}
