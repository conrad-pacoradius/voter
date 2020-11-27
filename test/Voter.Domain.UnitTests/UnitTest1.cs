using System;
using voter.domain;
using Xunit;

namespace Voter.Domain.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Add Population
            var person1 = new Person("Person 1", "Person 1 Last Name", new DateTime(1980, 1, 1));
            var person2 = new Person("Person 2", "Person 2 Last Name", new DateTime(1980, 1, 2));
            var person3 = new Person("Person 3", "Person 3 Last Name", new DateTime(1980, 1, 3));
            var person4 = new Person("Person 4", "Person 4 Last Name", new DateTime(1980, 1, 4));
            var person5 = new Person("Person 5", "Person 5 Last Name", new DateTime(1980, 1, 5));
            var person6 = new Person("Person 6", "Person 6 Last Name", new DateTime(1980, 1, 6));
            var person7 = new Person("Person 7", "Person 7 Last Name", new DateTime(1980, 1, 7));
            var person8 = new Person("Person 8", "Person 8 Last Name", new DateTime(1980, 1, 8));
            var person9 = new Person("Person 9", "Person 9 Last Name", new DateTime(1980, 1, 9));
            var person10 = new Person("Person 10", "Person 10 Last Name", new DateTime(1980, 1, 10));
            var person11 = new Person("Person 11", "Person 11 Last Name", new DateTime(1980, 1, 11));
            var person12 = new Person("Person 12", "Person 12 Last Name", new DateTime(1980, 1, 12));
            var person13 = new Person("Person 13", "Person 13 Last Name", new DateTime(1980, 1, 13));
            var person14 = new Person("Person 14", "Person 14 Last Name", new DateTime(1980, 1, 14));
            var person15 = new Person("Person 15", "Person 15 Last Name", new DateTime(1980, 1, 15));
            var person16 = new Person("Person 16", "Person 16 Last Name", new DateTime(1980, 1, 16));
            var person17 = new Person("Person 17", "Person 17 Last Name", new DateTime(1980, 1, 17));
            var person18 = new Person("Person 18", "Person 18 Last Name", new DateTime(1980, 1, 18));
            var person19 = new Person("Person 19", "Person 19 Last Name", new DateTime(1980, 1, 19));
            var person20 = new Person("Person 20", "Person 20 Last Name", new DateTime(1980, 1, 20));

            //Create Country
            var country1 = new Country("Country 1");


            //Create Political Entity
            var polity1 = new Polity("Political Entity 1");

            // Create Election
            var election = new Election();

            //Register Voters
            



            //Create new initiative
            var initiative1 = new Initiative();
        }
    }
}
