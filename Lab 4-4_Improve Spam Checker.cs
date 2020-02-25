using System;

namespace Lab_4_4_Improve_Spam_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            /*In this lab, we want to write an improved version of the Spam Check that checks
             * a list of words from the blacklist , and uses a for loop to check all words. 
             * Let’s also convert all of our messages to lower case so that things we don’t 
             * get missed hits due to capitalization. Here are the words for our new blacklist.
             * buy, viagra, XXX, free money, lifetime offer, send money, bank account, nigeria, 
             * online pharmacy, h8te, meet girls*/
            string[] blackList = {
            "buy", "viagra", "XXX", "free money",
            "lifetime offer", "send money", "bank account",
            "nigeria", "online pharmacy", "h8te", "meet girls" };

            string message = Console.ReadLine();
            bool isSpam = false;
            message = message.ToLower();
            for (int i = 0; i < blackList.Length; i++)
            {
                if (message.Contains(blackList[i]))
                {
                    isSpam = true;
                }
            }


            if (isSpam == true)
            {
                Console.WriteLine("The message contained spam");
            }
            else
            {
                Console.WriteLine("The Message is Ok.");
            }
        }
    }
}
