using System;

namespace Konsool3
{
    class Program3
    {
        static void Main3()
        {
         for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}