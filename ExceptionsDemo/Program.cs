using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Starship Serenity = new Starship("Serenity", "Firefly", "404-E-132-4FE274A", 9);
            Serenity.AddCrew("Captain", "Malcolm Reynolds");
            Serenity.AddCrew("FirstMate", "Zoe Washburne");
            Serenity.AddCrew("Pilot", "Hoban Washburne");
            Serenity.AddCrew("Engineer", "Kaywinnet Lee Frye");
            Serenity.AddCrew("PublicRelations", "Jayne Cobb");
            Serenity.AddCrew("Ambassador", "Inara Serra");
            Serenity.AddCrew("Shepherd", "Derrial Book");
            Serenity.AddCrew("Medic", "Simon Tam");
            Serenity.AddCrew("Crew", "River Tam");

            
            Serenity.Print();
            Serenity.PrintRoster();

            //Begin trying exception handling

            try
            {
                string position = "Saboteur";
                string name = "Axl Rose";
                //Too many crew members, not enough space
                if (Serenity.CurrentCrewSize() >= Serenity.CrewCapacity)
                {
                    throw new StarshipException(name);
                }
                else
                {
                    Serenity.AddCrew(position, name);
                }
            }
            catch (StarshipException e)
            {
                Console.WriteLine(e.Message);
            }

            //End trying exception handling

            Console.ReadLine();
        }
    }
}
