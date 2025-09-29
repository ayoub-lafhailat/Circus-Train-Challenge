using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CircusTrainChallenge
{
    public class Wagon
    {
        private const int MAX_WAARDE = 10;

        // deze functie maakt wagons en verdeelt de dieren op basis van grootte
        public List<List<Animal>> CheckWagon(List<Animal> animals)
        {
            // resultaat: lijst van wagons, elke wagon is een lijst met dieren
            List<List<Animal>> wagons = new List<List<Animal>>();

            // huidige wagon en huidige som
            List<Animal> animalsInWagon = new List<Animal>();
            int som = 0;

            // loop door alle dieren
            foreach (var dier in animals)
            {
                int waarde = (int)dier.Size;

                // past het dier nog in de huidige wagon?
                if (som + waarde <= MAX_WAARDE)
                {
                    animalsInWagon.Add(dier);
                    som += waarde;
                }
                else
                {
                    // huidige wagon klaar, voeg toe aan resultaat
                    if (animalsInWagon.Count > 0)
                    {
                        wagons.Add(animalsInWagon);
                    }

                    // nieuwe wagon beginnen met dit dier
                    animalsInWagon = new List<Animal>();
                    animalsInWagon.Add(dier);
                    som = waarde;
                }
            }

            wagons.ForEach(Console.WriteLine);
            return wagons;

            //ani mals.ForEach(Console.WriteLine);
        }

        //nog toevoegen de willeat veiligheidsfunctie
        //nog toevoegen de checkwagon moet elke keer vanaf begin van de wagons loopen en proberen het dier toe te voegen
        //voor meer optimale eindresultaat.


        //een functie maken om alleen te kijken of een dier nog qua size in de wagon past
        //kijken of met de willeat functie het dier in de wagon mag.
        //dus je hoeft het dier alleen met het dier in die wagon te vergelijken.
        //dus je maakt een loop die door de 2d list van de wagons gaat
        //dan kijkt die in elke list hoevol de wagon zit en of die er bij past
        //als die er bij past moet met de willeat functie gekeken worden of die er in mag
        //als die er in mag voeg je hem toe aan die list
        //en zo ga je door voor alle dieren
        //totdat alle dieren in een wagon zitten.

        //begin eerst simpel en kijk alleen of een dier in een wagon past
        //gebruik een vooraf gedefinieerde list animals gewoon heel simpel
        //en kijk of je kan controleren of een input animal in die wagon past.


        //bij wagons checken altijd vanaf eerste wagon beginnen om te checken
        // je wilt ze optimaal vullen dus vanaf de eerste wil je kijken of er nog een dier bij kan


    }
}
