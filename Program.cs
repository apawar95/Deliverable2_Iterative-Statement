using System;

namespace Deliverable2_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please, enter a number between 1 and 100");
            try
            {
                string input = Console.ReadLine();
                int number = int.Parse(input);

                if ((number >= 1) && (number <= 100))
                {
                    for (int i = 1; i < number + 1; i++)
                    {
                        Console.WriteLine("you entered:" + number.ToString() + "enteted vaule " + i.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("please enter number between 1 and 100");
                }
               } catch
            {
                Console.WriteLine("error! ");
            }

            }
        }
    }
