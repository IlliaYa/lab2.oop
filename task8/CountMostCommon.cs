using System;
class CountMostCommon
{
    static void Main()
    {
        int i = 0, K = 0, max=0, number = 0;
        Console.Write("enter your numbers (using enter)");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        for (i = 1; i < array.Length; i++)
        {
            for(int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    K++;
                }
            }
            if (K > max)
            {
                max = K;
                number = array[i];
            }
            K = 0;
        }
        Console.WriteLine("\n most common is number {0} (occurs {1} times)", number, max);
    }
}
