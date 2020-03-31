using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13_1_DesignPatterns
{
    class SingletonDatabase : DesignPatterns
    {
        //We have both a public and private version of property.
        //The property is static, which means belongs to class itself.

        private static SingletonDatabase _instance = null;
            public static SingletonDatabase Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SingletonDatabase();
                    //When a class asked for the public property, the constructor
                    //is called.
                }
                return _instance;
            }
        }

        private SingletonDatabase()
        {
            //the constructor is private. No other class can use it.
        }
    }
}
