using System;

namespace Fakertehtava
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var name = Faker.Name.FullName();
            var address = Faker.Address.StreetAddress();
            var city = Faker.Address.City();
            var number = Faker.RandomNumber.Next(100);
            var dob = Faker.Identification.DateOfBirth();
            var usPassport = Faker.Identification.UsPassportNumber();

            Console.WriteLine($"First person: {name} - {address} - {city} - {number} - {dob} - {usPassport}");

            var name3 = Faker.Name.FullName();
            var address3 = Faker.Address.StreetAddress();
            var city3 = Faker.Address.City();
            var number3 = Faker.RandomNumber.Next(100);
            var dob3 = Faker.Identification.DateOfBirth();
            var ukPassport3 = Faker.Identification.UkPassportNumber();

            Console.WriteLine($"Second person: {name3} - {address3} - {city3} - {number3} - {dob3} - {ukPassport3}");

            var name2 = Faker.Name.FullName();
            var address2 = Faker.Address.StreetAddress();
            var city2 = Faker.Address.City();
            var number2 = Faker.RandomNumber.Next(100);
            var dob2 = Faker.Identification.DateOfBirth();
            var usPassport2 = Faker.Identification.UsPassportNumber();

            Console.WriteLine($"Third person: {name2} - {address2} - {city2} - {number2} - {dob2} - {usPassport2}");
        }
    }
}
