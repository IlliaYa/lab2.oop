using System;
class MaxWords
{
    static void Main()
    {
        int i = 0, n1 = 0, n2 = 0, end1, end2;
        string[] sentance1 = { "Contrary", "to", "popular", "belief", ",", "Lorem", "Ipsum", "is", "not", "simply" };
        string[] sentance2 = { "Contrary", "There ", "are", "many", "variations", ",", "Lorem", "Ipsum", "is", "not", "simply" };
        end1 = sentance1.Length;
        end2 = sentance2.Length;

        while (sentance1[i] == sentance2[i])
        {
            n1++;
            i++;    
        }
        while (sentance1[end1 - i] == sentance2[end2 - i])
        {
            n2++;
            i++;
        }

        if (n1>n2)
        {
            Console.WriteLine("The largest common end is at the left: " );
            for (i = 0; i < n1; i++)
            {
                Console.WriteLine(sentance1[i]);
            }
        }
        else if(n2>n1)
        {
            Console.WriteLine("The largest common end is at the right: ");
            for (i = end2 - n2; i < end2; i++)
            {
                Console.WriteLine(sentance2[i]);
            }
        }
        else if(n1 == n2 && (n1!=0 || n2!=0))
        {
            Console.WriteLine("both sentances are the same");
        }
        else
        {
            Console.WriteLine("can`t find commond end");
        }
    }
}