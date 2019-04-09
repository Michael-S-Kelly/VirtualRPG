using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualRPG.Classes
{
    public class BlackMage : Magic
    {
        public override int Brains { get; set; }
        public override int HP { get; set; }

        public override void Cast()
        {
            Console.WriteLine("I got a spell for that....What was it....Oh yeah, Fireball");
        }

        public override void Talk()
        {
            Console.WriteLine("Not the FACE!");
        }
    }
}
