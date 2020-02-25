using System;

namespace Lab_4_6_Array_To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scenario:
        You work for a company that runs a To-Do list web app. The website allows users to
        type in tasks for each day of the week so that they remember to do them. You’ve been
        asked to use C# to create a small to-do list planner. As usual, someone else will handle
        how the code will work on the web, you’ve been asked to write the initial test version of
        the logic.
        
        Requirements:
        The do-to list planner will cycle through each day of the week, pausing to let the user
        type in a task. The planner will save each task the user types in, and then display all of
        the days and tasks together. 
        
        Tips:
        You will keep each day in an array of “days”.*/
            string[] days = new string[]
            {"Monday", "Tuesday", "Wednesday", "Thursady", "Friday", "Saturday", "Sunday"};

            // You’ll save the tasks in an array of “tasks”.
            string[] task = new string[7];

            //You need to setup for each loops to loop through the days and tasks.
            for (int i = 0; i < days.Length; i++) ;
            {
                Console.WriteLine("Type in a Task for" + days[i]);
                tasks[i] = days[i] + ":" + Console.ReadLine();
            }

            for (int i = 0; i < days.Length; i++) ;
            {
                Console.WriteLine(tasks[i]);
            }
        }

    }
}
