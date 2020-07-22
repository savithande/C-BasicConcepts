using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;
using System.Text;

namespace Sample_Practice_Programs
{
    class Alphabeticals
    {
        public void vowels(String str)
        {
            WriteLine("if condition Example ");
            Write("Enter a Chrector : ");

            char inputChar = System.Convert.ToChar(ReadLine());

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Contains(char.ToLower(inputChar)))
            {
                WriteLine("Charector "+ inputChar + " is a vowel.");
                ReadLine();
            }
            else
            {
                WriteLine("Charector " + inputChar + " is not a vowel.");
                ReadLine();

            }

        }

        public void maximunValue(int num1, int num2, int num3)
        {
            if(num1 > num2 && num1 > num3)
            {
                WriteLine("The num1 is greater");

            }else if(num2 > num1 && num2 > num3)
            {
                WriteLine("The num2 is greater");

            }else if(num3 > num1 && num3 > num2)
            {
                WriteLine("The num3 is greater");

            }else if(num1 == num2 && num1 == num3)
            {
                WriteLine("The num1=num2=num3");

            }else if(num1 == num2 | num2 == num3 | num1 == num3)
            {
                 
                if (num1 == num2)
                {
                    WriteLine(num1 + " == " + num2);
                } 
                if(num1 == num3)
                {
                    WriteLine(num1 + " == " + num3);
                }
                if(num2 == num3)
                {
                    WriteLine(num2 + " == " + num3);
                }
            } else
            {
                WriteLine("All are equal to Zero");
            }

        }
         
    }
}
