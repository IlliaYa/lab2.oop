using System;
class CountMostCommon
{
    static void Main()
    {
        int i = 0, K = 0, m=0, number = 0;
        Console.Write("enter your numbers (using enter)");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if(array.Length > 1)
        {
            for (i = 1; i < array.Length; i++)
            {
                if (array[i] == array.Max())
                {
                    m = i;

                }
            }
        }
        else
        {
            Console.WriteLine("0");
        }
        Console.WriteLine("\n most common is number {0} (occurs {1} times)", number);
    }
}