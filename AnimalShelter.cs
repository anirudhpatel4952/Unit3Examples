using System;
namespace AnimalShelter
{
    public class AnimalShelter 
    {
        //constructor
        public AnimalShelter(string TypeOfAnimalarg, bool AdoptionAvailabilityarg, int NoOfAnimalsarg){
            TypeOfAnimal = TypeOfAnimalarg;
            AdoptionAvailability = AdoptionAvailabilityarg;
            NoOfAnimals = NoOfAnimalsarg;
            AnimalDonation = false;
        }
        //datamembers
        //types of animals
        //animals available for adoption
        //pet returned from a person or found on a street
        //if found on a street, is it adopted or not
        //characteristics of them

        // class dog
        //class cat
        public string TypeOfAnimal { get; set; }
        public bool AdoptionAvailability { get; set; }
        public bool AnimalDonation { get; set; }
        public int  NoOfAnimals { get; set; }

        // public List<int> AnimalCount { get; set; }

        //method
        public void PrintShelterInfo() {
            Console.WriteLine($"This unit is a shelter for {TypeOfAnimal} & Followimg is the information available for this unit in the shelter: ");
            Console.WriteLine($"Is {TypeOfAnimal} available : {AdoptionAvailability}");
            Console.WriteLine($"No. of {TypeOfAnimal} available are : {NoOfAnimals}");
        }
        // public void AnimalCount(){
        //     if (TypeOfAnimal == "dog" && AdoptionAvailability == true){
        //         NoOfAnimals --;                
        //     }
    
    
        public void PrintAdoptDonate(){
            
            var userInputAD = Console.ReadLine().ToLower();
            if (userInputAD == "adopt"){
                NoOfAnimals --;

                }
            else if (userInputAD == "donate") {
                NoOfAnimals ++;
            }
            else {
                Console.WriteLine($"Please enter a valid input: adopt or donate");
            }
            }
        
    }
}
