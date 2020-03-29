using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson_9_ChildClass_FileWriter_SimpleClass_UserAccount
{
    class FileWriter : Program_Lesson9
    {
        private ContextStaticAttribute string userLogFile = "C:\\Weblogs\\Lesson_9_ChildClass_FileWriter_SimpleClass_UserAccount\\Lesson_9_ChildClass_FileWriter_SimpleClass_UserAccount.txt";

        public void ExampleWriteFile()
        {
            string fileName = "C:\\Weblogs\\Lesson_9_ChildClass_FileWriter_SimpleClass_UserAccount\\Lesson_9_ChildClass_FileWriter_SimpleClass_UserAccount\\FileWriter.txt";
            string data = "Print this info to a log. \n";
            File.AppendAllText(fileName, data);

        }

        public void UpdateUserLog(string userName, DateTime logonTime, bool wasLoginSuccessful)
        {
            if (wasLoginSuccessful == true)
            {
                string logEntry = userName + " successfully logged in at " + logonTime + "\n";
                File.AppendAllText(userLogFile, logEntry);
            }
            else
            {
                string logEntry = userName + " entered a bad password at " + logonTime + "\n";
                File.AppendAllText(userLogFile, logEntry);

            }
        }

        public void CreateHTML(StringBuilder htmlText)
        {
            File.WriteAllText("C:\\weblogs\\myHTML.html", htmlText.ToString());
        }

    }
}
