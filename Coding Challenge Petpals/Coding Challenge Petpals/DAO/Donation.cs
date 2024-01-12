using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coding_Challenge_Petpals.Util;
using Coding_Challenge_Petpals.exception;
using Coding_Challenge_Petpals.Entity;

namespace Coding_Challenge_Petpals.DAO
{
    public abstract class Donation
    {
        private string donorName = null;
        private PetShelter donatedTo;
        public string DonorName { get => donorName; set { donorName = value; } }
        public PetShelter DonatedTo { get => donatedTo; set { donatedTo = value; } }
        public Donation(string donorName, PetShelter donatedTo)
        {
            DonorName = donorName;
            DonatedTo = donatedTo;
        }

        public abstract bool RecordDonation();

        public static int AddDonation(string donorName, decimal donationAmount)
        {
            SqlConnection conn = null;
            SqlCommand cmd;
            try
            {
                conn = DBConnUtil.GetConnection();
                conn.Open();
                var donationItem = DBNull.Value;
                string q = $"INSERT INTO Donations (DonorName, DonationType, DonationAmount, DonationDate) VALUES (\'{donorName}\', 'Cash', {donationAmount}, \'{DateTime.Now}\')";
                cmd = new SqlCommand(q, conn);
                int dr = cmd.ExecuteNonQuery();
                if (dr > 0) { Console.WriteLine("Successfully added donation to database."); return 1; }
                else { Console.WriteLine("Could not add donation details to the database."); return 0; }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return 0; }
            finally
            {
                conn.Close();
            }
        }
    }
}
