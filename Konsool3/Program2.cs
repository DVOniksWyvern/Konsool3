using System;

namespace Konsool3
{
    class Program2
    {
        static void Main2()
        {
            int[] Numbers = new int[4];//data array of 4 entries

            Numbers[0] = 101;//entry 1
            Numbers[1] = 102;//entry 2
            Numbers[2] = 103;//entry 3
            Numbers[3] = 104;//entry 4

            foreach (int k in Numbers)//enumerates the elements of a collection and executes its body for each element of the collection
            {
                Console.WriteLine(k);//displays the string
            }

            //for (int j = 0; j <= Numbers.Length; j++)
            //{
            //    Console.WriteLine(Numbers[j]);
            //}
                
            //int i = 0;
            //while (i < Numbers.Length)
            //{
            //    Console.WriteLine(Numbers[i]);
            //    i++;
            //}
        }
    }
}