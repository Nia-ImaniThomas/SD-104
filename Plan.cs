using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8_Animal
{
    class Plan : Main
    {
        public enum Renewal
        {
            Monthly,
            SixMonth,
            Annual,
            TwoYear,
            ThreeYear
        }

        public Renewal renewal;

        public Plan()
        {

        }

        public void ChangeRenewal(Plan.Renewal renew)
        {
            renewal = renew;
        }
    }
}
