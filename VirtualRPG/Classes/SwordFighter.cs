using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualRPG.Classes
{
    class SwordFighter : Fighter
    {
        public override int Muscles { get; set; }
        public override int HP { get; set; }

        public override void Attack()
        {
            Console.WriteLine("The sword fighter swings their mighty sword");
        }

        public override void Talk()
        {
            Console.WriteLine("Eat my swords!!!!!!!!!!!!!");
        }
    }
}
