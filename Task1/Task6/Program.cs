using System;
class Task6
{
    static void Main()
    {
        Console.Write("write down something: "); string Text = Console.ReadLine();
        string correctedText = TXT(Text);
        Console.WriteLine(correctedText);
    }
    static string TXT(string x)
    {
        x = x.Replace('5', 'S');
        x = x.Replace('0', 'O');
        x = x.Replace('1', 'I');
        x = x.Replace("KYS", "NO!");
        return x;
    }
}