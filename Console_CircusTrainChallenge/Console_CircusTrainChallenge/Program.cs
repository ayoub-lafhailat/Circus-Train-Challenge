//hier moet de gebruiker input kunnen geven
//hoeveel dieren
//van welk soort
//welk grootte
//aantal dieren

using System;
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace Console_CircusTrainChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Diet diet = default;
            Size size = default;
            int aantal = 0;
            string status = "add";

            Console.WriteLine("Dit is de circus train challenge");
            Console.WriteLine("Selecteer je dieren: soort, grootte, hoeveel, continue");

            //dit moet eig geen infinite while loop zijn maar een loop die checkt op add/continue
            while (status == "add")
            {
                if (status == "continue")
                {
                    break;
                }

                //kan ook switch case zijn
                void ChooseDiet()
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

                ChooseDiet();
                
                //kan ook switch case zijn
                void ChooseSize()
                {
                    while (true)
                    {
                        Console.WriteLine("Kies je grootte");
                        Console.WriteLine("Small : 3");
                        Console.WriteLine("Medium : 5");
                        Console.WriteLine("Large : 7");


                        string grootte = Console.ReadLine();
                        if (grootte == "3")
                        {
                            size = Size.Small;
                            break;
                        }
                        else if (grootte == "5")
                        {
                            size = Size.Medium;
                            break;
                        }
                        else if (grootte == "7")
                        {
                            size = Size.Large;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Verkeerde input");
                        }
                    }
                }

                ChooseSize();

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

                for (int i = 0; i < aantal; i++)
                {
                    animals.Add(current);
                }

                animals.ForEach(Console.WriteLine);

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


                AddMoreAnimals();
                //hier komt de functie om de dieren te verdelen

                //stel je hebt 10 carnivoren, 3p, dan wil je 10 animal objecten carnivoor, 3p maken en toevoegen aan een list.

                //de soort en grootte dieren, de parameters voor de class dieren
                //die moeten het aantal x keer toegevoegd worden aan een list van dieren
                //die later weer gebruikt kan worden en verdeeld over de karren

                //dit moet blijven looppen totdat de gebruiker al zijn dieren heeft geselecteerd en verder wilt gaan

                //print de lijst 2d lijst van wagons met dieren
            }
        }
    }
}

//extra feature die de list van input random shuffeled zodat alle animals input door elkaar heen zitten.