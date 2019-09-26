using System;

namespace Zoo
{
    public class Animal
    {
        public string Color { get; set; }
        public string Gender { get; set; }
        protected string Noise { get; set; }


       public Animal(string gender, string color)
        {
            Color = color;
            Gender = gender;
        }

        public void MakeNoise()
        {
                Console.WriteLine(Noise);
        }
    }

}