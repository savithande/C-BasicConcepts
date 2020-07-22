using EO.Internal;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Sample_Practice_Programs
{
    public class DataTypes
    {
         
        public void Sample(int num1, int num2)
        {
             
            int num3;

            num3 = num1 + num2;

            String firstName = "Savitha";
            String place = "Bangalore";

            Console.WriteLine(num3);
            Console.WriteLine(firstName + ", " + place);
            Console.ReadLine();

        }
    }

   
}
