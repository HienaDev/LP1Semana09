using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal
    {

        public override float NumberOfNipples => 2;

        public override string Sound()
        {
            return base.Sound() + "<Click>";
        }
    }
}