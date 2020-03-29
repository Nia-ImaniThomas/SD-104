using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8_Animal
{//next principal of OOP_Inheritance
    abstract class Animal
    {/*Below, we have a class called Animal. All of our animals have a name, a certain
number of arms and legs, and could be dangerous or furry. Additionally, all of our
animals can sleep and eat.*/
        protected string name;
        protected int numOfLegs;
        protected int numOfArms;
        protected bool isDangerous;
        protected bool isFurry;
        public void Sleep()
        {
            Console.WriteLine("The" + this.GetType() + "goes to sleep.");
        }

        public void Eat()
        {
            Console.WriteLine("The" + this.GetType() + "goes to eat.");
        }

        public virtual void Breath()
        {
            Console.WriteLine("The animal breaths through it's nose!");
        }

        public abstract int Sell();
    }
}
