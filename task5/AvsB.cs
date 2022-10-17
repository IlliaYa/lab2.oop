using System;
using System.Linq;
class AvsB
{
    static void Main()
    {
        char[] word1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
        char[] word2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

        word1.ToList().ForEach(element => Console.Write($" {element}"));
        Console.Write("\n");
        word2.ToList().ForEach(element => Console.Write($" {element}"));
        Console.Write("\n");
        for (int i = 0; i < word1.Length; i++)
        {
            if (word1[i] < word2[i])
            {

                word1.ToList().ForEach(element => Console.Write($" {element}"));
                Console.Write("\n");
                word2.ToList().ForEach(element => Console.Write($" {element}"));
                break;

            }
            else if (word1[i] > word2[i])
            {
                word2.ToList().ForEach(element => Console.Write($" {element}"));
                Console.Write("\n");
                word1.ToList().ForEach(element => Console.Write($" {element}"));
                break;
            }
        }
    }
}


