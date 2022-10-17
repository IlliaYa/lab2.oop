using System;
class CountIncreas
{
    static void Main()
    {
        int i = 0, K = 1, max, endpoint = 0;
        Console.Write("enter your numbers (using enter)");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        max = 0;
        for (i = 1; i < array.Length; i++)
        {
            if (array[i] >= array[i - 1])
            {
                K++;
            }
            else
            {
                K = 0;
            }
            if (K > max)
            {
                max = K;
                endpoint = i;
            }
        }
        /* Console.Write("\n {0} {1} \n", max, endpoint);
        array.ToList().ForEach(element => Console.Write($" {element}")); */
        Console.WriteLine("\n longest list is:");
        for (i = endpoint - max; i <= endpoint; i++)
        {
            Console.Write("{0} ", array[i]);

        }
    }
}