using System;

namespace Lab_5_4_Mario
{
    class Program
    {
        private static object mario;

        public struct Mario
        {
            /*Scenario:
You work for a company that allows users to play classic video games on their web site.
You’ve been asked to re-create the classic character Mario for use on the website.
Using a struct, create various data points that makeup Mario.*/


           public enum Size
            {
                small,
                large
            }
            /*1. We need to begin by thinking of all of things that Mario might need. Let’s start
                 making a list. 

                 Here’s the list we came up with.
                 Number of lives
                 Number of gold coins
                 Current Stage
                 Size (small or large)
                 Can Shoot a fireball? (yes or no)
                 Is jumping right now ( yes or no)  */
            /*2. Now, let’s turn this into a struct. This code is written ABOVE the Main() Code
                 Block. Do not place it inside of it.   */


            public int numOfLives;
            public string currentLevel;
            public Size sizeOfMario;
            public bool canShootFireBalls;
            public bool isJumping;
            public int numOfCoins;
            internal static Mario mario;
        }

        /*3. Now in the Main() code block, let’s create Mario and give him some default values. 
         * Let’s play some Super Mario in C#
           Open the 5_4 LabStarter, read through the code. Change the values of Mario as
           directed as he moves through “the level.”*/
           static void Main(string[] arges)
        {
            Mario.mario = new Mario();
            mario.numOfLives = 3;
            mario.currentLevel = "World 1-1";
            mario.sizeOfMario = Mario.Size.small;
            mario.canShootFireBalls = false;
            mario.isJumping = false;
            mario.numOfCoins = 0;



            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jummping so he can kill it");
            //Write code here
            mario.isJumping = true;

            Console.WriteLine("Mario squashes the Goobs. Now he needs to land!");
            //Write code here
            mario.isJumping = false;

            Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
            //Write code here
            mario.numOfLives += 1;

            Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change Mario!");
            //Write code here
            mario.canShootFireBalls = true;
            
            Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario!");
            //Write code here
            mario.sizeOfMario = Mario.Size.large;
            
            Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
            //Write code here
            mario.numOfConis = 10;

            Console.WriteLine("Mario finshes the level! Change Mario's current level to World 1-2");
            //Write code here
            mario.currentLevel = "World 1-2";


        }
    }
}
