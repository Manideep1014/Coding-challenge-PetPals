using Coding_Challenge_Petpals.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coding_Challenge_Petpals.Util;
using Coding_Challenge_Petpals.exception;

namespace Coding_Challenge_Petpals.DAO
{
    public class AdoptionEvent 
    {
        public List<Participant> participants;
        private string eventName = null;

        public string EventName { get => eventName; set { eventName = value; } }
        public AdoptionEvent(string eventName)
        {
            participants = new List<Participant>();
            EventName = eventName;
            Console.WriteLine($"The adoption event {EventName} has been registered.");
        }
        public void Adopt(Pet pet, Participant participant)
        {
            participant.AdoptPet(pet);
        }

        public void HostEvent()
        {
            Console.WriteLine($"Hosting the adoption event {EventName}!");
        }
        public bool RegisterParticipant(Participant participant)
        {
            if (participant != null)
            {
                participants.Add(participant);
                return true;
            }
            return false;
        }

        public static void GetAllAdoptionEventDetails()
        {
            SqlConnection conn = null;
            SqlCommand cmd;
            SqlDataReader dr = null;
            try
            {
                conn = DBConnUtil.GetConnection();
                conn.Open();
                string q = "SELECT * FROM AdoptionEvents";
                cmd = new SqlCommand(q, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t{dr[3]}");
                }
                dr.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                conn.Close();
            }
        }

        public static void RegisterForAnEvent(string participantName, string participantType, int eventID)
        {
            SqlConnection conn = null;
            SqlCommand cmd;
            try
            {
                conn = DBConnUtil.GetConnection();
                conn.Open();
                var donationItem = DBNull.Value;
                string q = $"INSERT INTO Participants (ParticipantName, ParticipantType, EventID) VALUES (\'{participantName}\', \'{participantType}\', {eventID})";
                Console.WriteLine(q);
                cmd = new SqlCommand(q, conn);
                int dr = cmd.ExecuteNonQuery();
                if (dr > 0) Console.WriteLine($"Successfully registered participant {participantName} for the event with ID:{eventID}.");
                else Console.WriteLine("Could not register the participant!");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.Contains("The INSERT statement conflicted with the FOREIGN KEY constraint") ? "Invalid Event ID!" : ex.Message); }
            finally
            {
                conn.Close();
            }
        }
    }
}
