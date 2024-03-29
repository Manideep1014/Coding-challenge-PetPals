﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_Petpals.DAO
{
    public class ItemDonation : Donation
    {
        public static List<ItemDonation> itemDonations = new List<ItemDonation>();
        private string itemType = null;

        public string ItemType { get => itemType; set { itemType = value; } }
        public ItemDonation(string donorName, PetShelter donatedTo, string itemType) : base(donorName, donatedTo)
        {
            ItemType = itemType;
            RecordDonation();
        }

        public override bool RecordDonation()
        {
            if (this != null)
            {
                itemDonations.Add(this);
                return true;
            }
            return false;
        }
        public new void  ToString()
        {
            Console.WriteLine("Following are the item donations made:");
            foreach (var donation in itemDonations)
            {
                Console.WriteLine($"Name of Donor: {donation.DonorName} \t Item Donated: {donation.itemType} \t Donated to: {DonatedTo.ShelterName}");
            }
        }
    }
}
