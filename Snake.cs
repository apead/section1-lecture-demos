using Zoo;
using System;

namespace Zoo
{
    public class Snake : Animal
    {
        public Snake(string gender, string color) : base (gender, color)
        { 
            Noise = "SSSSSSSS";

        }
    }


}