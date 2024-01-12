using Coding_Challenge_Petpals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_Petpals.DAO
{
    public class Participant
    {
        private string name = null;
        private string type = null;
        public List<Pet> adoptions = null;

        public string Name { get => name; set { name = value; } }
        public string Type { get => type; set { type = value; } }
        public Participant(string name, string type)
        {
            Name = name;
            Type = type;
            if (adoptions == null) adoptions = new List<Pet>();
        }

        public void AdoptPet(Pet pet)
        {
            adoptions.Add(pet);
            Console.WriteLine($"Participant {Name} who is {(Type.ToLower() == "adopter" ? "an" : "a")} {Type} adopted the pet {pet.Name}.");
        }
    }
}
