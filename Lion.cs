using Zoo;
using System;

namespace Zoo
{
    public class Lion : Animal
    {
        public Lion(string gender, string color) : base (gender, color)
        { 
            Noise = "Roar";
        }
    }


}