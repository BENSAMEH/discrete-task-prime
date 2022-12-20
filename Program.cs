using System;

namespace prime_number_task_discrete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE FIRST NUMBER");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE SECOND NUMBER");
            int secondnumber = int.Parse(Console.ReadLine());

            for (int i = firstnumber; i <= secondnumber; i++)
            {
                bool isprime = true;
                
                
                    if (i % 2 == 0)
                    {
                        isprime = false;
                        continue;


                    }else if (i == 1)
                {
                    isprime = false;
                    continue;
                }
                    else
                    {
                        isprime = true;

                    }







                
                if (isprime == true)
                {
                    Console.WriteLine("THE NUMBER {0} IS PRIME", i);
                }



            }



        }
    }
}

