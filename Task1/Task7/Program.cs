using System;
class Task7
{
    static void Main()
    {
        Console.Write("How many times they played? "); int Games = int.Parse(Console.ReadLine());
        Random random = new Random();
        int[] GameRes = new int[Games];
        string GameR = "";
        for (int i = 0; i < Games; i++)
        {
            GameRes[i] = random.Next(0, 2);
        }
        foreach (int i in GameRes)
        {
            if (GameRes[i] == 1) { GameR += 'A'; }
            else { GameR += 'B'; }
        }
        Console.WriteLine(GameR);
        Console.WriteLine(DetermineWinner(Games, GameR));

    }
    static string DetermineWinner(int n, string s)
    {
        int aliceWins = 0;
        int bobWins = 0;

        foreach (char result in s)
        {
            if (result == 'A')
            {
                aliceWins++;
            }
            else if (result == 'B')
            {
                bobWins++;
            }
        }

        if (aliceWins > bobWins)
        {
            return "Alice";
        }
        else if (bobWins > aliceWins)
        {
            return "Bob";
        }
        else
        {
            return "Tie";
        }

    }
}
