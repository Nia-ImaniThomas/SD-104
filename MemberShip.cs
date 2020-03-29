using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8_Animal
{
    class MemberShip : Main
    {
        public enum Level
        {
            Basic,
            Preimum,
            Lifetime
        }

        public Plan plan;
        public Level level;

        public MemberShip()
        {
            plan = new Plan()
        }

        public void ChangeMemberShip(MemberShip.Level newLevel)
        {
            level = newLevel;
        }
    }
}
