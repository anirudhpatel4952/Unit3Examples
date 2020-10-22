using System;
using System.Collections.Generic;
namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please mention what kind of animals are you looking to adopt/donate: dog or cat?");
            var userInput = Console.ReadLine().ToLower();
           
           
            var dogShelter = new AnimalShelter("Dogs", true, 10);
            // AnimalShelter.PrintShelterInfo();
            var catShelter = new AnimalShelter("Cats", true, 8);
            if (userInput == "dog"){
                dogShelter.PrintShelterInfo();
                Console.WriteLine($"Are you here to adopt or donate?");
                dogShelter.PrintAdoptDonate();
                Console.WriteLine($"No. of dogs available are : {dogShelter.NoOfAnimals} ");

            }
            else if (userInput == "cat"){
                catShelter.PrintShelterInfo();
                Console.WriteLine($"Are you here to adopt or donate?");
                catShelter.PrintAdoptDonate();
                Console.WriteLine($"No. of cats available are : {catShelter.NoOfAnimals} ");
            }
            else {Console.WriteLine("Please enter a valid input: dog or cat \n Currently our animal shelter only is able to help dogs & cats");}
            
            
        }
    }
}
