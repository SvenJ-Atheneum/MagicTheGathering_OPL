using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MagicTheGathering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creeër 3 creatures:
            string ft = "Of royal blood among the spirits of the air, the Mahamoti Djinn rides on the wings of the winds. As dangerous in the gambling hall as he is in battle, he is a master of trickery and misdirection.";
            Creature djinn = new Creature("Mahamoti Djinn", new CastingCost(Land.ManaType.Water, 2, 4), "Flying", ft, 5, 6);
            ft = "In the forest villages of Kessig, parent feed their children wormwood and other bitter herbs, hoping to make them less palatable to things that roam in the night.";
            Creature kinderCatch = new Creature("KinderCatch", new CastingCost(Land.ManaType.Bos, 3, 3), "", ft, 6, 6);
            ft = "Folklore has it that to capture a mountain goat is a sign of divine blessing. I just know it's a sign that dinner is on the tray. -Klazina Jansdotter, Leader of the Order of the Sacred Torch.";
            Creature mountainGoat = new Creature("Mountain Goat", new CastingCost(Land.ManaType.Vuur, 1, 0), "Mountain Walk (If defending player controls any mountain, this creatures is unblockable)", ft, 1, 1);
            //steek creatures in array voor easy access.
            Creature[] creatures = {djinn, kinderCatch, mountainGoat};

            bool stop = false;
            while (!stop)
            {
                //Maken landen adhv gebruikers invoer.
                Console.WriteLine("We maken eerst al onze landkaarten aan:");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Aantal Water?");
                int water = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Aantal Bos?");
                int bos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Aantal Zon?");
                int zon = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Aantal Vuur?");
                int vuur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Aantal Dood?");
                int dood = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------------------------");
                int tot = water + bos + vuur + zon + dood;
                Land[] landen = new Land[tot];
                int i = 0;
                for (int j = 0; j < water; j++)
                {
                    Land land = new Land("Eiland", Land.ManaType.Water);
                    landen[i] = land;
                    i++;
                }
                for (int j = 0; j < bos; j++)
                {
                    Land land = new Land("Bos", Land.ManaType.Bos);
                    landen[i] = land;
                    i++;
                }
                for (int j = 0; j < zon; j++)
                {
                    Land land = new Land("Woestijn", Land.ManaType.Zon);
                    landen[i] = land;
                    i++;
                }
                for (int j = 0; j < vuur; j++)
                {
                    Land land = new Land("Lava", Land.ManaType.Vuur);
                    landen[i] = land;
                    i++;
                }
                for (int j = 0; j < dood; j++)
                {
                    Land land = new Land("Moeras", Land.ManaType.Dood);
                    landen[i] = land;
                    i++;
                }
                //print alle landen
                /*Console.WriteLine("Je hebt volgende landkaarten gemaakt: ");
                foreach(Land land in landen) { land.ShowLand(); }*/

                bool castStop = false;
                while (!castStop)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Which creature do you want to cast? (Give the correct number.)");
                    for (i = 1; i <= 3; i++)
                    {
                        Creature creature = creatures[i - 1];
                        Console.WriteLine($"{i}.");
                        creature.showCreature();
                    }
                    int chosenOne = Convert.ToInt32(Console.ReadLine());
                    Creature cr = creatures[chosenOne - 1];
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine($"You try to cast a {cr.CreatureName.ToUpper()}!");
                    if (Creature.canCast(landen, cr))
                    {
                        Console.WriteLine("Creature can be casted.");
                    }
                    else
                    {
                        Console.WriteLine("Creature can NOT be casted.");
                    }
                    Console.WriteLine("Do you want to try to cast a different creature? (y/N)");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if (ch != 'y') castStop = true;
                }
                Console.WriteLine("Do you want to try with different Land? (y/N)");
                char c = Convert.ToChar(Console.ReadLine());
                if (c != 'y') stop = true;
            }

        }
    }
}
