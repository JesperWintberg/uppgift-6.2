using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            störst(7, 6);
        }

        static void störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                Console.WriteLine($"{tal1} är det största talet");
            }

            else if(tal1 < tal2)
            {
                Console.WriteLine($"{tal2} är det största talet");
            }

            else
            {
                Console.WriteLine($"{tal1} och {tal2} är lika stora");
            }
        }
    }
}

