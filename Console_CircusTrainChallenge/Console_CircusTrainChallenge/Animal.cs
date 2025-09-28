using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Console_CircusTrainChallenge.Animal;
using static System.Runtime.InteropServices.JavaScript.JSType;

//de safety rules moeten hierin 
//je kan superclasses gebruiken voor herbivoor en carnivoor

namespace Console_CircusTrainChallenge
{
    public enum Diet
    {
        Herbivoor =1,
        Carnivoor =2
    }

    public enum Size
    {
        Small = 1,
        Medium = 3,
        Large = 5
    }
    public class Animal
    {
        public Size Size { get; }
        public Diet Diet { get; }

        public Animal(Size size, Diet diet)
        {
            Size = size;
            Diet = diet;
        }
        public bool WillEat(Animal animal)
        {
            //je hoeft alleen te checken of het een carnivoor is want een herbivoor boeit toch niet
            if (this.Diet == Diet.Carnivoor)
            {
                //deze conditie checked of de grootte van de het huidige dier groter of gelijk is aan ander dier
                if (this.Size >= animal.Size)
                {
                    return true;
                }
                return false;
            }
            else 
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.Diet + " " + this.Size;
        }

    }
}
