using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterTest.Core;
using Repository.Core;
using CharacterTest.Core.Models;

namespace CharacterTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            CharacterObj ch = new CharacterObj();
            RaceObj r = new RaceObj();
            ClassObj c = new ClassObj();
            StatsObj t = new StatsObj();
            t.ClassObject = c;
            t.RaceObject = r;
            /* ch.CharacterClass.Name;
            ch.CharacterRace.Name;
            ch.Name; 
            Random diceroll = new Random();
            r.STRENGTH = diceroll.Next(8, 12);
            r.AGILITY = diceroll.Next(8, 12);
            r.INTELLIGENCE = diceroll.Next(8, 12);
            r.DEXTERITY = diceroll.Next(8, 12);
            r.VITALITY = diceroll.Next(8, 12);
            c.STRModifier = diceroll.Next(0, 5);
            c.AGIModifier = diceroll.Next(0, 5);
            c.INTModifier = diceroll.Next(0, 5);
            c.DEXModifier = diceroll.Next(0, 5);
            c.VITModifier = diceroll.Next(0, 5); */

                        
            Console.WriteLine("Once upon a time, in a far away land full of magic and swords...");
            Console.WriteLine("...Ah man screw that crap, this about kicking some ass and taking names!");
            Console.WriteLine("But first, tell me your name.");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Seriously? Your name is " + name + "? What kind of f***ing name is that?");
            Console.WriteLine("Screw it, you shall be Sir " + name + " of Bad-Assitude");
            Console.WriteLine("\nNow then, tell me son, what is your race of choice?");
            r.Name = Console.ReadLine();
            Console.WriteLine("....A WHAT? The hell is a " + r.Name + "?! Whatever, your fantasy dude.");
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            
            Console.WriteLine("NOW WHAT JOB DO YOU WANT TO BE WHEN YOU GROW UP!?");
            c.Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("A " + c.Name + "? Sounds like you would make your parents cry in embarassment.");
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear(); 

            Console.WriteLine("Whatever floats your boat! IT'S YOUR LIFE CHOICES, I DON'T CAREEE!");
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Now I will roll the dice of epic awesome explosions for your stats. HOLD PLEASE!");
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Rolling for STRENGTH!...");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("Rolling for Agility...");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("Rolling for VIIIIITALITY!...");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("F*** it, rolling for everything else. TOO MUCH WAITING!!!!!");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();

            Console.WriteLine("YOU AWAKE PANSY ?! Here's your racial stats!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nYOUR ASS KICKING STRENGTH IS... " + r.STRENGTH + "!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nYour swift agility is " + r.AGILITY + "!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nYour healthy vitality is " + r.VITALITY + "!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nYOUR BRAIN POWER INTELLIGENCE IS... " + r.INTELLIGENCE + "!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nAnd lastly your dex-a-what? DEXTERITY?! Oh that is " + r.DEXTERITY + ".");
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Your class stats BECAUSE YOU NEED MORE STATS!!!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nYour puny strength is " + c.STRModifier + "!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nThe agility bonus is " + c.AGIModifier + "!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nYour extra vitality is " + c.VITModifier + "!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nMORE BRAIN POWER? YES!! " + c.INTModifier + "!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nBECAUSE WE ALL NEED MORE DEXTERITY!! " + c.DEXModifier + "!");
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("WOW LOOK AT ALL THESE TOTAL STATS! HOLY SHIT!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nSTRENGTH: " + t.STRENGTH);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nAGILITY: " + t.AGILITY);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nVITALITY: " + t.VITALITY);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nINTELLIGENCE: " + t.INTELLIGENCE);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\nDEXTERITY: " + t.DEXTERITY);
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("ARE YOU READY TO PLAY?! GOOD!!");
            Console.WriteLine("\r\nEnd Game -- For now...");
            Console.ReadKey();
        }
    }
}
