using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterTest.Core;
using Repository.Core;
using CharacterTest.Core.Models;
using CharacterTest.Core.DataAccess;
using System.Data.Entity;

namespace CharacterTest
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region Declarations
            DbContext context1 = new GameDBContext();
            RaceService rserv = new RaceService(context1);
            Random droll = new Random();
            RaceObj r = new RaceObj();
            StatsObj t = new StatsObj();
            CharacterObj ch = new CharacterObj();
            ClassObj c = new ClassObj();
            ClassService cserv = new ClassService(context1);
            var rerace = true;
            var reclass = true;
            int restatr = 0;
            int restatc = 0;
            t.ClassObject = c;
            t.RaceObject = r;
            r.STRENGTH = droll.Next(7, 12);
            r.AGILITY = droll.Next(7, 12);
            r.VITALITY = droll.Next(7, 12);
            r.DEXTERITY = droll.Next(7, 12);
            r.INTELLIGENCE = droll.Next(7, 12);
            #endregion

            #region Beginning
            Console.WriteLine("Once upon a time, in a far away land full of magic and swords...");
            Console.WriteLine("...Ah man screw that crap, this about kicking some ass and taking names!");
            Console.WriteLine("But first, tell me your name.");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Seriously? Your name is " + name + "? What kind of f***ing name is that?");
            Console.WriteLine("Screw it, you shall be Sir " + name + " of Bad-Assitude");
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region RaceCreation
            while (rerace)
            {
                Console.WriteLine("Now then, choose from the list of races you would like to be.");
                Console.WriteLine("Enter the number corresponding to the race of choice...OR GET LOST!");
                Console.WriteLine("1. Human");
                Console.WriteLine("2. Orc");
                Console.WriteLine("3. Elf");
                Console.WriteLine("4. Undead");
                Console.WriteLine("5. Demon");
                string x = Console.ReadLine();
                rerace = false;
                switch (x)
                {
                    case "1":
                        Console.WriteLine("\r\nYou have chosen to be a human! The most average of all classes....BORING!");
                        r.Name = "Human";
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("\r\nYou have chosen to be an orc! Ugly bastards...");
                        r.Name = "Orc";
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("\r\nAn elf? Really? Bunch of fairies if you ask me.");
                        r.Name = "Elf";
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("\r\nThe mighty undead! Hordes a million! Smelly lot though.");
                        r.Name = "Undead";
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("\r\nDEMON? SOMEBODY CALL AN EXORCIST! QUICK!!");
                        r.Name = "Demon";
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("\r\nYou chose none of the options provided. TRY AGAIN MONKEY!");
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        rerace = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            Console.WriteLine("Your stats are as follows:");
            Console.WriteLine("STRENGTH: " + r.STRENGTH);
            Console.WriteLine("AGILITY: " + r.AGILITY);
            Console.WriteLine("VITALITY: " + r.VITALITY);
            Console.WriteLine("INTELLIGENCE: " + r.INTELLIGENCE);
            Console.WriteLine("DEXTERITY: " + r.DEXTERITY);
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            while (restatr <= 2)
            {
                int stattot1 = 3 - restatr;
                Console.WriteLine("You may choose to add three additional points to any stat.");
                Console.WriteLine("You have " + stattot1 + " points left to choose from.");
                Console.WriteLine("1. Strength");
                Console.WriteLine("2. Agility");
                Console.WriteLine("3. Vitality");
                Console.WriteLine("4. Intelligence");
                Console.WriteLine("5. Dexterity");
                string y = Console.ReadLine();
                switch (y)
                {
                    case "1":
                        r.STRENGTH++;
                        restatr++;
                        Console.Clear();
                        break;
                    case "2":
                        r.AGILITY++;
                        restatr++;
                        Console.Clear();
                        break;
                    case "3":
                        r.VITALITY++;
                        restatr++;
                        Console.Clear();
                        break;
                    case "4":
                        r.INTELLIGENCE++;
                        restatr++;
                        Console.Clear();
                        break;
                    case "5":
                        r.DEXTERITY++;
                        Console.Clear();
                        restatr++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Your new stats are as follows:");
            Console.WriteLine("STRENGTH: " + r.STRENGTH);
            Console.WriteLine("AGILITY: " + r.AGILITY);
            Console.WriteLine("VITALITY: " + r.VITALITY);
            Console.WriteLine("INTELLIGENCE: " + r.INTELLIGENCE);
            Console.WriteLine("DEXTERITY: " + r.DEXTERITY);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // Submit race item
            // rserv.Insert(r);
            #endregion

            #region ClassCreation
            Console.WriteLine("Now that we got that dreaded long-winded race building out of the way...");
            Console.WriteLine("NOW COMES THE TIME....the time for a job. A class per say.");
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            while (reclass)
            {
                Console.WriteLine("PICK ONE OF THESE LOVELY JOBS YOU DIRTY " + r.Name);
                Console.WriteLine("1. WARRIOR!");
                Console.WriteLine("2. Mage!");
                Console.WriteLine("3. Thief...");
                Console.WriteLine("4. Archer");
                string z = Console.ReadLine();
                reclass = false;
                switch (z)
                {
                    case "1":
                        Console.WriteLine("\r\nBrave choice! You have chosen the warrior!");
                        c.Name = "Warrior";
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("\r\nI can smell great magicks inside you!");
                        c.Name = "Mage";
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("\r\nI got knicked by a thief once. Was that you?!");
                        c.Name = "Thief";
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("\r\nAn archer? Pfft, scaredy cat.");
                        c.Name = "Archer";
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("\r\nYou chose none of the options provided. TRY AGAIN IMBECILE!");
                        Console.WriteLine("\r\n\nPress any key to continue...");
                        reclass = true;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            Console.WriteLine("Your class choice has given you 8 stat points available to assign.");
            Console.WriteLine("DECIDE WISELY!");

            while (restatc <= 7)
            {
                int stattot2 = 8 - restatc;
                Console.WriteLine("You have " + stattot2 + " points left to choose from.");
                Console.WriteLine("1. Strength");
                Console.WriteLine("2. Agility");
                Console.WriteLine("3. Vitality");
                Console.WriteLine("4. Intelligence");
                Console.WriteLine("5. Dexterity");
                string v = Console.ReadLine();
                switch (v)
                {
                    case "1":
                        c.STRModifier++;
                        restatc++;
                        Console.Clear();
                        break;
                    case "2":
                        c.AGIModifier++;
                        restatc++;
                        Console.Clear();
                        break;
                    case "3":
                        c.VITModifier++;
                        restatc++;
                        Console.Clear();
                        break;
                    case "4":
                        c.INTModifier++;
                        restatc++;
                        Console.Clear();
                        break;
                    case "5":
                        c.DEXModifier++;
                        restatc++;
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Your chosen stats are as follows:");
            Console.WriteLine("STRENGTH: " + c.STRModifier);
            Console.WriteLine("AGILITY: " + c.AGIModifier);
            Console.WriteLine("VITALITY: " + c.VITModifier);
            Console.WriteLine("INTELLIGENCE: " + c.INTModifier);
            Console.WriteLine("DEXTERITY: " + c.DEXModifier);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // Submit Class Item
            // cserv.Insert(c);
            #endregion

            #region SpitOutStats
            Console.WriteLine("Now that we have SOMETHING to work with here,");
            Console.WriteLine("let's see your total stats shall we?");
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Strength is a whopping " + t.STRENGTH);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Your swift agility is " + t.AGILITY);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Your healthy vitality is " + t.VITALITY);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Your sharp intelligence is " + t.INTELLIGENCE);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("And dexterity comes out to " + t.DEXTERITY);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("The End....for now");
            Console.ReadKey();
            #endregion
        }
    }
}
