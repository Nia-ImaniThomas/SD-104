using System;

namespace Lab_8_RealityTV
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseHunter hhContestant = new HouseHunter("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "2/4/1975",
                "111 Brvo Way", "Los Angeles", "California", 90001, "888 -233-1234", "omar.smith@hotmail.com");

            ParadiseIsland piContestant = new ParadiseIsland("Female", "Carl", 2 "Patti", "Johnson", "5/4/1994", "211 Love Rd", "Los Angels",
                "California", 90001, "988-444-1234", "patti.jognson@gmail.com");

            AboveDeck adContestant = new AboveDeck(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Rd", "Los Angels",
                "California", 90001, "711-333-1234", "captian@gmail.com");

            hhContestant.Submit();
            hhContestant.Accept();


            piContestant.Submit();
            piContestant.Accept();


            adContestant.Submit();
            adContestant.Accept();
        }
    }
}
