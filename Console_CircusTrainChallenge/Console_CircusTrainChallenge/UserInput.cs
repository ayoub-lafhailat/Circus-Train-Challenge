using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CircusTrainChallenge
{
    public class UserInput
    {
        List<Animal> animals = new List<Animal>();
        Diet diet = default;
        Size size = default;
        int aantal = 0;
        string status = "add";

        //kan ook switch case zijn
        public void ChooseDiet()
        {
            while (true)
            {
                Console.WriteLine("Kies je soort:");
                Console.WriteLine("Herbivore : 1");
                Console.WriteLine("Carnivore : 2");

                string soort = Console.ReadLine();
                if (soort == "1")
                {
                    diet = Diet.Herbivoor;
                    break;
                }
                else if (soort == "2")
                {
                    diet = Diet.Carnivoor;
                    break;
                }
                else
                {
                    Console.WriteLine("Verkeerde input");
                }
            }
        }

        //kan ook switch case zijn
        public void ChooseSize()
        {
            while (true)
            {
                Console.WriteLine("Kies je grootte");
                Console.WriteLine("Small : 1");
                Console.WriteLine("Medium : 3");
                Console.WriteLine("Large : 5");


                string grootte = Console.ReadLine();
                if (grootte == "1")
                {
                    size = Size.Small;
                    break;
                }
                else if (grootte == "3")
                {
                    size = Size.Medium;
                    break;
                }
                else if (grootte == "5")
                {
                    size = Size.Large;
                    break;
                }
                else
                {
                    Console.WriteLine("Verkeerde input");
                }
            }

            void ChooseAantal()
            {
                Console.WriteLine("Kies je aantal");
                aantal = Convert.ToInt32(Console.ReadLine());
            }

            ChooseAantal();

            var current = new Animal(size, diet);

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals.Count == 0)
                {
                    break;
                }
                else
                {
                    var animal = animals[i];
                    Console.WriteLine(current.WillEat(animal));
                }

            }

            void AddMoreAnimals()
            {
                while (true)
                {
                    Console.WriteLine("Do you want to add more animals?");
                    Console.WriteLine("Add");
                    Console.WriteLine("Continue");

                    status = Console.ReadLine().ToLower();

                    if (status == "add")
                    {

                        break;
                    }
                    else if (status == "continue")
                    {
                        Console.WriteLine("dit is de verdeel wagon functie");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Verkeerde input, probeer opnieuw");
                    }
                }
            }
        }
    }
}
