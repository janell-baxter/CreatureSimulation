using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatureSimulation
{
    public class World
    {
        List<Creature> Creatures = new List<Creature>()
        {
            new Gryphon(){Name = "Gina the Gryphon" },
            new Dragon(){Name = "Daniel the Dragon" },
            new Sasquatch() {Name = "Samson the Sasquatch" }
        }
        ;

        public delegate void PrintPlatform(string message);
        public PrintPlatform Print;

        public void PrintConsole(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintWPF(string message)
        {
            //statements for WPF here
        }

        public World()
        {
            
        }

        public void Run()
        {
            Print = PrintConsole;
            Print(ShowCreatureNames());

            Console.ReadKey();
        }

        private string ShowCreatureNames()
        {
            string output = "";

            foreach (Creature c in Creatures)
            {
                output += c.Name + Environment.NewLine;
                output += c.Communicate() + Environment.NewLine;
                if (c is IMagic)
                {
                    output += "** A magical creature **" + Environment.NewLine;
                }
            }
      
            return output;
        } 
       
    }
}