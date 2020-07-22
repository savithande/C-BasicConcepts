using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Practice_Programs
{
    class Weeks
    {
        public void findTheDay(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }

        public void conditionOperator(int num)
        {
            while(num < 5)
            {
                Console.WriteLine(num);
                num++;
            }

            while(num > 5)
            {
                Console.WriteLine(num);
                num--;
            }

            do
            {
                Console.WriteLine("Greater than 5");
                num++;
            } while (num < 5);
        }

        public void carslist(String[] cars)
        {
            foreach (String i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
