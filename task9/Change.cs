using System;
class Change
{
    static void Main()
    {
        int i, f;
        char[] word1 = Console.ReadLine().Split().Select(char.Parse).ToArray();

        word1.ToList().ForEach(element => Console.Write($" {element}"));
        Console.Write("\n");
        for (i = 0; i < word1.Length; i++)
        {
            Console.WriteLine("{0} -> {1}", word1[i], (int)(word1[i] - 97));
        }
    }
}
