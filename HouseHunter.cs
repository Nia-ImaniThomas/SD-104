using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8_RealityTV
{
    class HouseHunter : Application
    {
        public string jobTitle;
        public int currentAnnualIncome;
        public int WhenBuyingMonths;
        public int bedrooms;
        public int bathrooms;

        public HouseHunter(string jobTitle, int currentAnnualIncome, int WhenBuying, int bedrooms, int bathrooms,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {
            this.jobTitle = jobTitle;
            this.currentAnnualIncome = currentAnnualIncome;
            this.WhenBuyingMonths = WhenBuying;
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Dream House Hunters");
        }
    }
}
