using System;

namespace Lab_3_5_Spam_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scenario:
 You work for a company that runs a web site. One of the features of the site is that
 users are able to post comments online and engage with each other in a discussion on
 the site.
 Lately, the message boards have been flooded with spam and other inappropriate
 postings. There is so much spam coming in the human moderators of the site can’t
 keep up.
 You’ve been asked by your boss to implement a spam checker for the web site. You
 work as part of a large team, so you’ve only been tasked with writing the code for the
 spam checking itself, and you don’t have to worry about how it hooks up to the web
 pages. Using C#, write a small program that will check messages for spam.

     Write some Pseudocode
     1. Blacklist = a word to check
     2. message = get content of message.
     3. test if the message contains the word.
     4. If it contains the word, spam is true,
     5. If not, the message is ok to post to the web site.*/
            string blackListWord = "robots";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");
            }
        }
    }
}
