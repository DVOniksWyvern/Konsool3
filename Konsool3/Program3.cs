using System;

namespace Konsool3
{
    class Program3
    {
        static void Main3()
        {
         for (int i = 0; i <= 20; i++)//execution a statement or a block of the statement
            {
                if (i % 2 == 1) //if i - 2 is 1 then
                    continue;//continue with the command

                Console.WriteLine(i);//display i
            }
        }
    }
}