using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace HumaneSociety
{

     class EmployeeClass
    {
        Employee employee = new Employee();
            public EmployeeClass()
        {
                
        }
        public void Login()
        {
            Console.WriteLine("What is your employee login number?");
            int GetNumber = int.Parse(Console.ReadLine());
            DataBaseAccessor context = new DataBaseAccessor();
            foreach (var search in context.Employee)
            {
                if (search.ID == GetNumber)
                {
                    Console.WriteLine("Animal Type: " + search.Animaltype + "\n" + "Name: " + search.Name + "\n" + "Gender: " + search.Gender + "\n" + "Room Number: " + search.RoomKeptIn + "\n" + "Adoption Status: " + search.AdoptionStatus + "\n" + "Price: " + search.Worth + "\n" + "Medical Shots: " + search.Shots + "\n" + "Hunger Level: " + search.Hunger + "\n" + "Age: " + search.Age + "\n" + "Breed: " + search.Breed);
                    Console.ReadLine();
                }

            }
            Console.WriteLine("invalid repsonce. Try again or exit \n 1 = Try again \n2 = Exit");
            int TryagainExit = int.Parse(Console.ReadLine());
            switch (TryagainExit) {
            case 1:
                    Login();
             return;
                case 2:
                    UI ui = new HumaneSociety.UI();
                    ui.InsertInfo();
                    return;
        }
        }
        static void MainMenu()
        {
           
        }
    }
}