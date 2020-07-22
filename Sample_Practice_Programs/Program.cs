using System;
using System.Threading.Tasks.Dataflow;

namespace Sample_Practice_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Savitha!");

            Console.WriteLine("Enter the number  between i to 7 to find the day in a week");
            int num = Convert.ToInt32(Console.ReadLine());

            Parent parent = new Parent();
            parent.speedOfTheCar();
            Console.WriteLine();
            Console.WriteLine();


            Weeks week = new Weeks();
            week.findTheDay(num);
            Console.WriteLine(); 
            week.conditionOperator(num);
            Console.WriteLine();


            int i;
            String[] cars = new string[5];
            Console.WriteLine("Enter the cars list");
            for (i = 0; i <= cars.Length - 1; i++)
            {
                cars[i] = Console.ReadLine();
            }

            week.carslist(cars);
            Console.WriteLine();



            Console.WriteLine();

            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter your Place : ");
            String place = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter your Phone: ");
            long ph = System.Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter DOB : ");
            String dob = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Name = " + name);
            Console.WriteLine();
            Console.Write("Place = " + place);
            Console.WriteLine();
            Console.Write("Phone Number = " + ph);
            Console.WriteLine();
            Console.Write("DOB = " + dob);
            Console.WriteLine();

            DataTypes obj = new DataTypes();
            obj.Sample(10, 20);

            MathsOperations mo = new MathsOperations();
            mo.add(20, 30);
            mo.sub(30, 20);
            mo.mul(56, 5);
            mo.div(36, 12);
            mo.mod(13, 65);

            Alphabeticals al = new Alphabeticals();
            al.vowels("savitha");
            al.maximunValue(10, 200, 30);
 
            _ = Console.ReadLine();
 

        }
    }
}
