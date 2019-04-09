using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualRPG.Classes
{
    public abstract class Fighter : Character
    {
        public abstract int Muscles { get; set; }
        public virtual int Armor { get; set; }

        public abstract void Attack();
        public virtual void Jump()
        {
            Console.WriteLine("The fighter leaps 8 feet straight into the air!");
        }
    }
}
