using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13_1_DesignPatterns
{
    class ClassA : DesignPatterns
    {
        private int _myState;

        public delegate void NotifyMyObservers(int change);
        public NotifyMyObservers notify;

        public ClassA()
        {
            _myState = 0;
        }

        public void ChangeMe(int newState)
        {
            _myState = newState;
            notify(newState);
        }

    }

    class FirstObserver
    {

        private ClassA whatIAmObserving;

        public FirstObserver(ClassA theSource)
        {
            whatIAmObserving = theSource;
            whatIAmObserving.notify += OnEvent;
        }

        public void OnEvent(int theChange)
        {
            Console.WriteLine(" First Observer: I was notified that ClassA changed. " + theChange);

        }

    }

    class SecondObserver
    {

        private ClassA whatIAmObserving;

        public SecondObserver(ClassA theSource)
        {
            whatIAmObserving = theSource;
            whatIAmObserving.notify += OnEvent;
        }

        public void OnEvent(int theChange)
        {
            Console.WriteLine(" Second Observer: I was notified that ClassA changed. " + theChange);

        }
    }
}
