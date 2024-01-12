using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coding_Challenge_Petpals.Util;
using Coding_Challenge_Petpals.exception;


namespace Coding_Challenge_Petpals.Entity
{
    public class Pet
    {
        private string name = null;
        private int age;
        private string breed = null;

        public string Name { get => name; set { name = value; } }
        public int Age
        {
            get => age;
            set
            {
                if (value < 1) throw new InvalidPetAgeException("Invalid pet age! Enter a positive integer.");
                else age = value;
            }
        }
        public string Breed { get => breed; set { breed = value; } }

        public Pet(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public override string ToString()
        {
            if (Name == null || Age == 0 || Breed == null) throw new NullReferenceException("Missing pet information! Please recheck your data.");
            return $"Name of Pet: {Name} \t Age: {Age} \t Breed: {Breed}\n";
        }

        public static void GetAllPets()
        {
            SqlConnection conn = null;
            SqlCommand cmd;
            SqlDataReader dr = null;
            try
            {
                conn = DBConnUtil.GetConnection();
                conn.Open();
                string q = "SELECT * FROM Pets";
                cmd = new SqlCommand(q, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t{dr[3]}\t{dr[4]}\t{dr[5]}");
                }
                dr.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                conn.Close();
            }
        }
    }
}
