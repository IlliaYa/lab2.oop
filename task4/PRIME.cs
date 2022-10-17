class PRIME
{
    static void Main()
    {
        int i, j, ctr = 0;
        Console.Write("number:");
        int n = Convert.ToInt32(Console.ReadLine());


        for (i = 1; i <= n; i++)
        {
            ctr = 0;

            for (j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr == 0 && i != 1)
                Console.Write("{0} ", i);
        }
        Console.Write("\n");
    }
}

