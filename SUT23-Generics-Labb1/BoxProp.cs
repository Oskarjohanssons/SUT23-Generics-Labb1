using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Generics_Labb1
{
    internal class BoxProp:EqualityComparer<Box>
    {
        public override bool Equals(Box? B1, Box? B2)
        {
            if(B1.Width == B2.Width && B1.Length == B2.Length && B1.Height == B2.Height
                && B1.Volume == B2.Volume)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode(Box b)
        {
            return b.GetHashCode();
        }
    }
}
