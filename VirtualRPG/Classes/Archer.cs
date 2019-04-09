using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualRPG.Classes
{
    public class Archer : Fighter
    {
        public override int Muscles { get; set; }
        public override int HP { get; set; }

        public override void Attack()
        {
            Console.WriteLine("PEW PEW PEW");
        }

        public override void Talk()
        {
            Console.WriteLine("Orc On a Stiiick!!");
        }
    }
}
