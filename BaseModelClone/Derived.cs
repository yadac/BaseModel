using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModelClone
{
    class Derived : Base
    {
        private User c;
        private User C { get { return this.c; } }

        public Derived(User a, int b, User c) : base(a, b)
        {
            this.c = c;
        }

        public override object Clone()
        {
            
        }

    }
}
