using System;
class Backflip
{
    static void Main()
    {
        int i = 0, k;
        Console.Write("how much numbers:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter your numbers (using enter)");
        int[] array = new int[n];
        for (i = 0; i < n; i++) 
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int[] sum = new int[n];
        for (i = 0; i < n; i++) 
        {
            sum[i] = array[i];
        }
        Console.Write("how much times to rotate:");
        k = int.Parse(Console.ReadLine());
        
        for (i = 0; i < k;i++)
        {
            int flip = array[0];
            array[0] = array[n-1];
            array[n-1] = flip;
            for (int j = 0; j < n; j++)
            {
                sum[j] = sum[j] + array[j];
                Console.Write("{0} ", array[j]);
            }
        }
        Console.WriteLine("sum:");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0} ", sum[i]);

        }
    }
}
