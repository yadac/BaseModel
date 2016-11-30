using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModelClone
{
    class Base : ICloneable
    {
        private User a;
        private int b;

        public User A { get { return this.a; } }
        public int B { get { return this.b; } }

        public Base(User a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public virtual object Clone()
        {
            Base instance = (Base) this.MemberwiseClone();
            instance.a = (User) this.a.Clone();
            return instance;

        }
    }
}
