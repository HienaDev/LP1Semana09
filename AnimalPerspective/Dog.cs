﻿using System;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {

        public override float NumberOfNipples => 8;

        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
