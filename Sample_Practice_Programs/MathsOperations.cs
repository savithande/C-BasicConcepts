using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_Practice_Programs
{
    class MathsOperations
    {
        public void add(int num1, int num2)
        {
            int num3;
            num3 = num1 + num2;
            Console.WriteLine("addition of num1 and num2 is" +num3);
            Console.ReadLine();
        }

        public void sub(int num1, int num2)
        {
            int num3;
            num3 = num1 - num2;
            Console.WriteLine("subtraction of num1 and num2 is" +num3);
            Console.ReadLine();
        }

        public void mul(int num1, int num2)
        {
            int num3;
            num3 = num1 * num2;
            Console.WriteLine("multiplication of num1 and num2 is" + num3);
            Console.ReadLine();
        }

        public void div(int num1, int num2)
        {
            int num3;
            num3 = num1 / num2;
            Console.WriteLine("Division of num1 and num2 is " +num3);
            Console.ReadLine();
        }

        public void mod(int num1, int num2)
        {
            int num3;
            num3 = num1 % num2;
            Console.WriteLine("Modulos of num1 and num2 is " + num3);
            Console.ReadLine();
        }


    }
}
