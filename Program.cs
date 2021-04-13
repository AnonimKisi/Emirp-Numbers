//Made by AnonimKisi
using System;

namespace ConsoleApp1
{
    class Program
    {
        static int number = 13;

        public static int Reverse(int reverse)
        {
            int temp_number = number;
            reverse = 0;
            goto_point:
            if (temp_number > 0)
            {
                int reverse_flag = temp_number % 10;
                reverse = (reverse * 10) + reverse_flag;
                temp_number = temp_number / 10;
                goto goto_point;
            }
            return reverse;
        }

        static void Main()
        {
            Console.Title = "Made by AnonimKisi";

              int  half = number / 2, i, flag = 0;

                Console.WriteLine("-------------------------------");           
                Console.WriteLine("I want to list all emirp number between 13 and X.");
                Console.WriteLine("X can be min. 100 and max. 1000\n");
                Console.Write("X: ");           

                int X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (X < 100 || X > 1000)
                {
                    Main();
                }
                else
                {
                    while (number < X)
                    {
                        //check if number is prime
                        for (i = 2; i <= half; i++)
                        {
                            if (number % i == 0)
                            {
                                flag = 1;
                            }
                        }

                        //-----------------------------------------------

                        //if it is, start checking if its reverse also is
                        if (flag == 0)
                        {
                            int reverse = Reverse(6);//choosed a number which isn't prime, on purpose (avoided using 4 in respects to Mista) 
                            half = reverse / 2;

                            for (i = 2; i <= half; i++)
                            {
                                if (reverse % i == 0)
                                {
                                    flag = 1;
                                }
                            }
                            if (flag == 0)
                            {
                                Console.Write(number + ", ");
                            }
                        }
                        number++;
                        half = number / 2;
                        flag = 0;
                    }
                }
            number = 13;
            Console.Write("\b\b \n\n");
            Main();
        }
    }
}
