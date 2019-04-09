using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualRPG.Classes
{
    public abstract class Character
    {
        public abstract int HP { get; set; }
        public virtual int AC { get; set; }

        public abstract void Talk();
        public virtual void TakeDamage()
        {
            HP--;
        }
    }
}
