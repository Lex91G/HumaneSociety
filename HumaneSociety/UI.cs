using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace HumaneSociety
{
   class UI
    {
        Employee employee = new Employee();
        Animal newanimal = new Animal();
        public UI()
        {

        }
        public void InsertInfo()
        {
            Console.WriteLine("Welcome to the Alex's Human Society how may I help you? \n1 = Bring an animal in? \n2 = Search for an animal? \n3 = Search by ID? \n4 = Employee login");
            int WhatTheredoing = int.Parse(Console.ReadLine());
            switch (WhatTheredoing)
            {
                case 1:
                    BringAnimalIn();
                    return;
                case 2:
                    FindAnAnimal();
                    return;

                case 3:
                    SearchByID();
                    return;

                default:
                    Console.WriteLine("Invalid response please try again");
                    InsertInfo();
                    return;
            }
        ;
        }
        public void BringAnimalIn()
        {
            Console.WriteLine("What kind of animal are you bringing in?");
            string whatAnimal = Console.ReadLine();
            newanimal.Animaltype = whatAnimal;
            NameOfAnimal();
        }
        public void NameOfAnimal()
        {
            Console.WriteLine("What is the animals name?");
            string WhatsAnimalName = Console.ReadLine();
             newanimal.Name = WhatsAnimalName;
            GenderOfAnimal();
        }
        public void GenderOfAnimal()
        {
            Console.WriteLine("What is the gender of the animal?");
            string WhatAnimalGender = Console.ReadLine();
            newanimal.Gender = WhatAnimalGender;
            roomKeptIn();
        }
        public void roomKeptIn()
        {
            int? roomNumber=0;
            newanimal.RoomKeptIn = roomNumber;
            roomNumber++;
            AdoptionStatus();
        }
        public void AdoptionStatus()
        {
            newanimal.AdoptionStatus = "Not adopted yet";
            Age();
        }
        public void Age()
        {
            Console.WriteLine("How old is the animal?");
            int? getAge = int.Parse(Console.ReadLine());
            newanimal.Age = getAge;
            AnimalWorth();
        }
        public void AnimalWorth()
        {
            Console.WriteLine("How much would you like to sell your animal for?");
            decimal? GetWorth = decimal.Parse(Console.ReadLine());
            newanimal.Worth = GetWorth;
            Shots();
        }
        public void Shots()
        {
            Console.WriteLine("Is the animal up to date on shots?");
            string DoesAnimalHaveShots = Console.ReadLine();
            newanimal.Shots = DoesAnimalHaveShots;
            HungerLevel();
        }
        public void HungerLevel()
        {
            Console.WriteLine("Out of a ten, what would be your animals hunger level?");
            int? getHungerLevel = int.Parse(Console.ReadLine());
            newanimal.Hunger = getHungerLevel;
            Breed();
        }
        public void Breed()
        {
            Console.WriteLine("Does your animal have a breed, if so what breed is your animal?");
            string getAnimalBreed = Console.ReadLine();
            newanimal.Breed = getAnimalBreed;
            DataClasses1DataContext context = new DataClasses1DataContext();
            context.Animals.InsertOnSubmit(newanimal);
            context.SubmitChanges();
            InsertInfo();
            
        }

        public void FindAnAnimal()
        {
            UpdateAnimal();
            var test = DataBaseAccessor.AnimalRecords();
            foreach (var search in test)
            {
                Console.WriteLine("ID Number: " + search.ID + "\n" + "Animal Type: " + search.Animaltype +"\n" + "Name: " + search.Name + "\n" + "Gender: " + search.Gender + "\n" + "Room Number: " + search.RoomKeptIn + "\n" + "Adoption Status: " + search.AdoptionStatus + "\n" + "Price: " + search.Worth + "\n" + "Medical Shots: " + search.Shots + "\n" + "Hunger Level: " + search.Hunger + "\n" + "Age: " + search.Age + "\n" + "Breed: " + search.Breed);
                Console.ReadLine();

            }

            InsertInfo();
        }
        public void SearchByID()
        {
            Console.WriteLine("Whats the animals ID number you would like to look up?");
            int IDNumber = int.Parse(Console.ReadLine());
            DataClasses1DataContext context = new DataClasses1DataContext();
            foreach (var search in context.Animals)
            {
                if (search.ID == IDNumber)
                {
                    Console.WriteLine("Animal Type: " + search.Animaltype + "\n" + "Name: " + search.Name + "\n" + "Gender: " + search.Gender + "\n" + "Room Number: " + search.RoomKeptIn + "\n" + "Adoption Status: " +search.AdoptionStatus + "\n" + "Price: " + search.Worth + "\n" + "Medical Shots: " + search.Shots + "\n" + "Hunger Level: " + search.Hunger + "\n" + "Age: " + search.Age + "\n" + "Breed: " + search.Breed);
                    Console.ReadLine();

                }

            }

        }

        
        public void UpdateAnimal()
        {
           if(newanimal.AdoptionStatus == "Not adopted yet")
            {
                string newAdopted = "Adopted";
                newanimal.AdoptionStatus = newAdopted;
                DataClasses1DataContext context = new DataClasses1DataContext();
                context.Animals.InsertOnSubmit(newanimal);
                context.SubmitChanges();
                
            }
            
        }
              
            
            
                
            
           
        //    DataBaseAccessor.UpdateAnimal(newanimal);
            
        //    //var results = x context.animals where breed SELECT dataentry;
        

        //}

        }
    }

