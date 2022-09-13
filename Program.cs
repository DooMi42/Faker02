using System;

namespace Fakertehtava
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding matrix text color ;)
            Console.ForegroundColor = ConsoleColor.Green;

            //Introduction to the program
            #region

            Console.WriteLine("Welcome to the program! Read the instructions below.\n" +
                "\nUse command line argument: --personcount and press enter here.\n" +
                "\nOr\n" +
                "\nUse command line argument: --interactive and Type: --interactive to use the program.\n");
            Console.Write("Type here: ");
            string first = Console.ReadLine();
            #endregion

            //Personcount code
            #region
            if (args.Length == 0)
            {
                Console.WriteLine("No command line parameters given, Please enter parameter.");
                return;
            }
            string firstParameter = args[0];

            if (firstParameter == "--personCount" || firstParameter == "--personcount")
            {
                if (args.Length == 1)
                {
                    Console.WriteLine("ERROR: specify personcount value in command line argument.");
                    return;
                }

                int howMany = Convert.ToInt32(args[1]);

                Console.WriteLine("\nGiving you " + howMany + " fake persons data ENJOY!");

                for (int i = 0; i < howMany; i++)
                {
                    FakerMethod();
                }
            }
            #endregion

            //Interactive code
            #region
            if (first == "--interActive" || first == "--interactive")
            {
                Console.WriteLine("\nHow many fake persons data you want?");

                int amount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    FakerMethod();
                }
            }
            #endregion
        }

        //FakerMethod
        #region
        private static void FakerMethod()
        {
            Console.WriteLine("");

            var name = Faker.Name.FullName();
            var address = Faker.Address.StreetAddress();
            var city = Faker.Address.City();
            var number = Faker.RandomNumber.Next(100);
            var dob = Faker.Identification.DateOfBirth();
            var usPassport = Faker.Identification.UsPassportNumber();

            Console.WriteLine($"Person: {name} - {address} - {city} - {number} - {dob} - {usPassport}");
        }
        #endregion
    }
}
