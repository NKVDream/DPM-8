using System;
using System.Collections.Generic;

class Task5
{
    static void Main()
    {
        Console.Write("write down something: "); var X = Console.ReadLine();
        int powerOfBoolean = Task5.PB(X, out int bollpower);
        Console.WriteLine($"Power of Boolean is: {powerOfBoolean}");
        List<char> current = new List<char>();
        Subsets(X, 0, current);
    }
    static int PB(string x, out int bollpower)
    {
        int count = 0;
        foreach (char i in x) {  count++; }
        bollpower = (int)Math.Pow(2, count);
        return bollpower;
    }

    static void Subsets(string X, int index, List<char> current)
    {
        if (index == X.Length)
        {
            Console.WriteLine(string.Join(", ", current));
            return;
        }
        current.Add(X[index]);
        Subsets(X, index + 1, current);

        current.RemoveAt(current.Count - 1);
        Subsets(X, index + 1, current);
    }
}
