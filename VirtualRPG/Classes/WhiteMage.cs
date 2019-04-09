using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualRPG.Classes
{
    public class WhiteMage : Magic
    {
        public override int Brains { get; set; }
        public override int HP { get; set; }

        public override void Cast()
        {
            Console.WriteLine("Medic!!Medic!!");
        }

        public override void Talk()
        {
            Console.WriteLine("SHWWOSH YOU'RE HeAleD");
        }
    }
}
