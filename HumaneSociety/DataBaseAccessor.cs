using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Data.Linq;

namespace HumaneSociety
{
    class DataBaseAccessor
    {
        public static List<Animal> AnimalRecords()
        {

            DataClasses1DataContext context = new DataClasses1DataContext();
            var result = from r in context.Animals select r;
            
            return result.ToList();

        }
        public static Animal Getfile(string AnimalType)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            Animal Animaltype = (from r in context.Animals
                                 where r.Animaltype == AnimalType
                                 select r).First();
            Console.WriteLine(Animaltype);
            return Animaltype;
        }
        public static bool AddAnimal(Animal animal)
        {
            try
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                context.Animals.InsertOnSubmit(animal);
                context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool DeleteAnimal(string ID)
        {
            try
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                Animal obj = (from r in context.Animals
                              where r.Name.Contains(ID)
                              select r).First();
                if (obj != null)
                {
                    context.Animals.DeleteOnSubmit(obj);
                    context.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        
        public static bool UpdateAnimal(Animal animal)
        {
            try
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                Animal res = (from r in context.Animals
                              where r.Animaltype.Contains(animal.Animaltype)
                              select r
                                          ).First();
                res.Animaltype = animal.Animaltype;
                res.ID = animal.ID;
                res.Name = animal.Name;
                res.Gender = animal.Gender;
                res.RoomKeptIn = animal.RoomKeptIn;
                res.AdoptionStatus = animal.AdoptionStatus;
                res.Worth = animal.Worth;
                res.Shots = animal.Shots;
                context.SubmitChanges();
                return false;
            }
              catch
            {
                return false;
            }
        }
        public static bool AddNewAnimal(List<Animal> newAnimal)
        {
            try
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                context.Animals.InsertAllOnSubmit(newAnimal);
                context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool DeleteAnimalEntirely(List<Animal> deleteAnimal)
        {
            try
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                context.Animals.DeleteAllOnSubmit(deleteAnimal);
                context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
