using System;
using System.Collections.Generic;

namespace Lab_4_5_Trivia_Website_Leaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scenario:
        You work for a company that runs a trivia web site. Users of the site compete by
        answering trivia questions to get the best score possible. One of the features of the site
        is that users are able to see a list of high scores.
        You’ve been asked to use C# to create the score leaderboard logic. You work for a
        large team, so someone else will worry about getting it to display on the page, your task
        is to implement the code logic.
        You’ve been given these scores to work with.
        Score
        4400
        8900
        1200
        3700
        7200*/


            /* Using C# lists, do the following.
        1. Create a list that holds the scores you’ve been given.*/
            List<int> scores = new List<int>();
            scores.Add(4400);
            scores.Add(8900);
            scores.Add(1200);
            scores.Add(3700);
            scores.Add(7200);

            //2. Sort the scores lowest to highest and output to the screen.
            scores.Sort();
            foreach (int s in scores) ;
                {
                Console.WriteLine(s);
            }

            //3. Sort the scores highest to lowest and output to the screen.
            scores.Reverse();
            foreach (int s in scores) ;
            {
                Console.WriteLine(s);
            }

            /*4. You’ve just been given a new score that wasn’t part of the original list. Add the score
            2400 to the list.*/
            scores.Add(2400);

            /*5.. A user has closed their account and needs to have all of their information deleted.
            Remove the score 4400 from the list.*/
            scores.Remove(4400);
        }
    }
}
