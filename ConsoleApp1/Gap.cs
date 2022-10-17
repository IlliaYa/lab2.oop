using System;
class Gap
{
    static void Main()
    {
        int i = 0, j;
        Console.Write("enter your numbers (using enter)");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine("enter the gap: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i < array.Length; i++)
        {
            for (j = 0; j < array.Length; j++)
            {
                if (array[i] - array[j] == n)
                {
                    Console.Write(" ({0};{1})  ", array[i], array[j]);
                }
            }

        }
    }
}
