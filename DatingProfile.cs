using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7_Dating_Website
{/*The Scenario:
You work for a company that operates a dating website. You’ve been asked to create
C# classes that the web site will use to help online daters find their match! You work on
a team, so another developer will be taking the code you create and output it to the
web--your only job is to write the class code. Let’s get started!
PART 1 - Create the Dating Profile.
1. Create a new class called DatingProfile.   */
    class DaitingProfile
    { 
            /*2.Dating Profile will have the following properties
                ● Public string First Name
                ● Private string Last Name
                ● Public int Age
                ● Public string Gender
                ● Public string Bio*/
        public string firstName;
        private string lastName;
        public int age;
        public string gender;
        public string bio;
        private List<Messages> myMessages;
        /*3. DatingProfile needs a constructor that lets us fill out firstname, lastname, age, and
                gender of the profile.    */
        public DatingProfile(string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            myMessages = new List<Messages>();
        }/* 4. Dating Profile will have the following methods
● WriteBio(string text) - This will let the user write their bio text to their profile.
● ReadMessage() - This will let the user read their messages.
● SendMessage(string MessageTitle, string MessageData, DatingProfile toProfile)
The send message method takes another Dating Profile as input and some text of the
message.   */
        public void WriteBio(string text)
        {
            bio = text;
        }

        public void AddToInbox(Messages message)
        {
            myMessages.Add(message);
        }

        public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            sentTo.AddToInbox(message);
        }

        public void ReadMessage()
        {
            foreach (Messages message in myMessages)
            {
                if(message.isRead == false)
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }

            }
        }
    }
}

