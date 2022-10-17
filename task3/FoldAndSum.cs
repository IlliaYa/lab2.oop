

using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        int i;
        Console.Write("how much numbers:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter your numbers (using enter)");
        int[] array = new int[n];
        for (i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] length1 = array.Take(array.Length / 4).ToArray();
        Array.Reverse(length1);

        int[] lastElements = array
            .Skip(array.Length - (array.Length / 4))
            .Take(array.Length / 4)
            .ToArray();
        Array.Reverse(lastElements);

        int[] concatedElements = length1.Concat(lastElements).ToArray();

        int[] middleElements = array
                   .Skip(array.Length / 4)
                   .Take(array.Length / 2)
                   .ToArray();

        int[] sum = new int[middleElements.Length];

        for ( i = 0; i < sum.Length; i++)
        {
            sum[i] = middleElements[i] + concatedElements[i];
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}