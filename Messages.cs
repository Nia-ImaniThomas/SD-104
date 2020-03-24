using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7_Dating_Website
{/*Part 2 - Create the Message Class
Next, create a Message Class that will represent the messages.
1. Create a new class called Messages*/
    class Message
    {/*2. Messages will have the following properties
● Public DatingProfile sender
● Public string MessageTitle
● Public string MessageData
● Private bool isRead*/
        public DatingProfile sender;
        public string messageTitle;
        public string messageData;
        private bool isRead;

        /*3. Create a constructor that sets the value for sender, title, and message data. The
isRead should default to false.*/
public Messages(DatingProfile sender, string messageTitle, string messageData)
        {
            this.sender = sender;
            this.messageTitle = messageTitle;
            this.messageData = messageData;
            isRead = false;
        }
    }
}
