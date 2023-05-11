using System;

namespace AnimalPerspective
{
    public class Cat : Animal, IMammal
    {

        public override float NumberOfNipples => 6;

        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
}
