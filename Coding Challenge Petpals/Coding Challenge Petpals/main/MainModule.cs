using Coding_Challenge_Petpals.DAO;
using Coding_Challenge_Petpals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coding_Challenge_Petpals.exception;
using Coding_Challenge_Petpals.Util;
using System.Threading;

namespace Coding_Challenge_Petpals
{
    internal class MainModule
    {
        static void Main(string[] args)
        {
            bool menu = false;
            while (!menu)
            {
                
                Console.WriteLine("\n\n============================================================");
                Console.WriteLine("\tWelcome to PetPals, A Pet Adoption Platform");
                Console.WriteLine("============================================================");
                Console.WriteLine("\n1.GetAllPets");
                Console.WriteLine("2.AddDonation");
                Console.WriteLine("3.GetAllAdoptionEvents");
                Console.WriteLine("4.RegisterForEvent");
                Console.WriteLine("\nPlease select an option:");
                int option = int.Parse(Console.ReadLine());
                    
                    switch (option)
                    {
                        case 1:
                        Console.Clear();
                        try
                        {
                            //GetAllPet();
                            Pet.GetAllPets();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 2:
                        Console.Clear();    
                        try
                        {
                            Console.WriteLine("Enter Donor name: ");
                            string s = Console.ReadLine();
                            Console.WriteLine("Enter Donation Amount: ");
                            decimal f = decimal.Parse(Console.ReadLine());
                            if(f>500)
                            {
                                Donation.AddDonation(s, f);
                            }
                            else
                            {
                                throw new InsufficientFundsException("Donation Amount should be greater than 500Rs");
                            }
                            
                        }
                        catch(Exception e) 
                        { 
                            Console.WriteLine(e.Message);
                        }
  
                            break;
                        case 3:
                        Console.Clear();
                        try
                        {
                            AdoptionEvent.GetAllAdoptionEventDetails();
                        }
                        catch(Exception e) 
                        {
                            Console.WriteLine(e.Message);   
                        }
                        break;
                        case 4:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the Participant Name: ");
                            string str = Console.ReadLine();
                            Console.WriteLine("Enter the Pariticipant Type(Adopter/Shelter): ");
                            string sr = Console.ReadLine();
                            Console.WriteLine("Enter the EventID: ");
                            int ID = int.Parse(Console.ReadLine());
                            AdoptionEvent.RegisterForAnEvent(str, sr, ID);
                        }
                        catch (Exception e) 
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                        default:
                        Exit();
                            break;
                    }
                Thread.Sleep(1000);
            }
        }
        public static void Exit()
        {
            Console.Write("Exiting...");
            Thread.Sleep(2000);
            Console.WriteLine();
            Environment.Exit(0);
        }
    }
}
