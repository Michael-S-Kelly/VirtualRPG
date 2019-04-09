using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualRPG.Classes
{
    public abstract class Magic : Character
    {
        public abstract int Brains { get; set; }
        public virtual int Cloak { get; set; }

        public abstract void Cast();
        public virtual void Read()
        {
            Console.WriteLine("Hmm yes this is a very good book, yes");
        }
    }
}
