using System;
using System.Text;
using ClassTesting.Models;

namespace ClassTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(10, 40);


            NewPlace:
            Console.WriteLine("Plea2se Choose\n1 for Refuel\n2 for drive\n3for info");
            string input = Console.ReadLine().Trim().ToUpper();

            switch (input)
            {
                case "1":
                    car.Refuel();
                    goto NewPlace;
                case "2":
                    Console.WriteLine(car.Drive(HowMuchDrive()));
                    goto NewPlace;
                case "3":
                    Console.WriteLine(car.ToString());
                    goto NewPlace;
                default:
                    Console.WriteLine("Invalid Input");
                    goto NewPlace;
            }
        }

        public static double HowMuchDrive()
        {
            TryAgain:
            Console.Write("Please enter the value that you want to drive: ");
            string input = Console.ReadLine();
            double convValue = 0;
            try
            {
                convValue = Convert.ToDouble(input);
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Invalid!\nTry Again!");
                goto TryAgain;
            }

            return convValue;
        }
    }
}
