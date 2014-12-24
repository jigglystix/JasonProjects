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
        #region Main Story
        public static void Main(string[] args)
        {

            #region Declarations
            DbContext context1 = new GameDBContext();
            RaceService rserv = new RaceService(context1);
            ClassService cserv = new ClassService(context1);
            CharacterObj ch = new CharacterObj();
            StatsObj t = new StatsObj();
            #endregion

            #region Call to Story Chunks
            string charName = BeginningMenu();

            RaceObj r = RaceCreationMenu();
            r = ModifyRaceStats(r, 3);
            t.RaceObject = r;
            

            ClassObj c = ClassCreationMenu(r.Name);
            c = ModifyClassStats(c, 8);
            t.ClassObject = c;

            t = StatViewingMenu(t.STRENGTH, t.AGILITY, t.VITALITY, t.INTELLIGENCE, t.DEXTERITY);
            #endregion

            #region SQL related artifacts
            // Submit race item
            rserv.Insert(r);
            rserv.SelectByDate(DateTime.Now);

            // Submit class item
            cserv.Insert(c);
            #endregion
        }
        #endregion

        #region Beginning of Chaos
        private static string BeginningMenu()
        {
            Console.WriteLine("Once upon a time, in a far away land full of magic and swords...");
            Console.WriteLine("...Ah man screw that crap, this about kicking some ass and taking names!");
            Console.WriteLine("But first, tell me your name.");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Seriously? Your name is " + name + "? What kind of f***ing name is that?");
            Console.WriteLine("Screw it, you shall be Sir " + name + " of Bad-Assitude");
            WaitAndClear();
            return name;
        }
        #endregion

        #region Race Related Functions
        private static RaceObj RaceCreationMenu()
        {
            RaceObj r = new RaceObj();
            Random droll = new Random();
            // initialize the race object
            r.CreatedUtc = DateTime.Now;
            r.CreatedBy = "Seed";
            r.STRENGTH = droll.Next(7, 12);
            r.AGILITY = droll.Next(7, 12);
            r.VITALITY = droll.Next(7, 12);
            r.DEXTERITY = droll.Next(7, 12);
            r.INTELLIGENCE = droll.Next(7, 12);

            bool isValidRace = true;
            while (isValidRace)
            {
                Console.WriteLine("Now then, choose from the list of races you would like to be.");
                Console.WriteLine("Enter the number corresponding to the race of choice...OR GET LOST!");
                Console.WriteLine("1. Human");
                Console.WriteLine("2. Orc");
                Console.WriteLine("3. Elf");
                Console.WriteLine("4. Undead");
                Console.WriteLine("5. Demon");
                string x = Console.ReadLine();
                isValidRace = false;
                switch (x)
                {
                    case "1":
                        Console.WriteLine("\r\nYou have chosen to be a human! The most average of all classes....BORING!");
                        r.Name = "Human";
                        break;
                    case "2":
                        Console.WriteLine("\r\nYou have chosen to be an orc! Ugly bastards...");
                        r.Name = "Orc";
                        break;
                    case "3":
                        Console.WriteLine("\r\nAn elf? Really? Bunch of fairies if you ask me.");
                        r.Name = "Elf";
                        break;
                    case "4":
                        Console.WriteLine("\r\nThe mighty undead! Hordes a million! Smelly lot though.");
                        r.Name = "Undead";
                        break;
                    case "5":
                        Console.WriteLine("\r\nDEMON? SOMEBODY CALL AN EXORCIST! QUICK!!");
                        r.Name = "Demon";
                        break;
                    default:
                        isValidRace = true;
                        Console.WriteLine("\r\nYou chose none of the options provided. TRY AGAIN MONKEY!");
                        break;
                }
                WaitAndClear();
            }

            ShowStats("Your stats are as follows:", r);
            WaitAndClear();

            return r;
        }

        private static RaceObj ModifyRaceStats(RaceObj r, int statPoints)
        {
            int remainingPoints = statPoints;
            while (remainingPoints > 0)
            {
                Console.WriteLine("You may choose to add three additional points to any stat.");
                Console.WriteLine("You have " + remainingPoints + " points left to choose from.");
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
                        remainingPoints--;
                        break;
                    case "2":
                        r.AGILITY++;
                        remainingPoints--;
                        break;
                    case "3":
                        r.VITALITY++;
                        remainingPoints--;
                        break;
                    case "4":
                        r.INTELLIGENCE++;
                        remainingPoints--;
                        break;
                    case "5":
                        r.DEXTERITY++;
                        remainingPoints--;
                        break;
                    default:
                        break;
                }              
                Console.Clear();
            }

            ShowStats("Your new stats are as follows:", r);
            System.Threading.Thread.Sleep(1000);
            WaitAndClear();
            return r;
        }
        #endregion

        #region Class Related Functions
        private static ClassObj ClassCreationMenu(string name)
        {
            ClassObj c = new ClassObj();
            bool isValidClass = true;
            c.CreatedUtc = DateTime.Now;
            c.CreatedBy = "Seed";

            Console.WriteLine("Now that we got that dreaded long-winded race building out of the way...");
            Console.WriteLine("NOW COMES THE TIME....the time for a job. A class per say.");
            WaitAndClear();

            while (isValidClass)
            {
                Console.WriteLine("PICK ONE OF THESE LOVELY JOBS YOU DIRTY " + name);
                Console.WriteLine("1. WARRIOR!");
                Console.WriteLine("2. Mage!");
                Console.WriteLine("3. Thief...");
                Console.WriteLine("4. Archer");
                string z = Console.ReadLine();
                isValidClass = false;
                switch (z)
                {
                    case "1":
                        Console.WriteLine("\r\nBrave choice! You have chosen the warrior!");
                        c.Name = "Warrior";
                        break;
                    case "2":
                        Console.WriteLine("\r\nI can smell great magicks inside you!");
                        c.Name = "Mage";
                        break;
                    case "3":
                        Console.WriteLine("\r\nI got knicked by a thief once. Was that you?!");
                        c.Name = "Thief";
                        break;
                    case "4":
                        Console.WriteLine("\r\nAn archer? Pfft, scaredy cat.");
                        c.Name = "Archer";
                        break;
                    default:
                        Console.WriteLine("\r\nYou chose none of the options provided. TRY AGAIN IMBECILE!");
                        isValidClass = true;
                        break;
                }
                WaitAndClear();
            }
            return c;
        }

        private static ClassObj ModifyClassStats(ClassObj c, int statPoints)
        {
            Console.WriteLine("Your class choice has given you 8 stat points available to assign.");
            Console.WriteLine("DECIDE WISELY!");

            int remainingPoints = statPoints;
            while (remainingPoints > 0)
            {
                Console.WriteLine("You have " + remainingPoints + " points left to choose from.");
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
                        remainingPoints--;
                        Console.Clear();
                        break;
                    case "2":
                        c.AGIModifier++;
                        remainingPoints--;
                        Console.Clear();
                        break;
                    case "3":
                        c.VITModifier++;
                        remainingPoints--;
                        Console.Clear();
                        break;
                    case "4":
                        c.INTModifier++;
                        remainingPoints--;
                        Console.Clear();
                        break;
                    case "5":
                        c.DEXModifier++;
                        remainingPoints--;
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }

            ShowStats("Your chosen stats are as follows:", c);
            System.Threading.Thread.Sleep(2000);
            WaitAndClear();
            return c;
        }
        #endregion

        #region Stat Related Function
        private static StatsObj StatViewingMenu(int strength, int agility, int vitality, int intelligence, int dexterity)
        {
            StatsObj t = new StatsObj();
            Console.WriteLine("Now that we have SOMETHING to work with here,");
            Console.WriteLine("let's see your total stats shall we?");
            WaitAndClear();

            Console.WriteLine("Strength is a whopping " + strength);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Your swift agility is " + agility);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Your healthy vitality is " + vitality);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Your sharp intelligence is " + intelligence);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("And dexterity comes out to " + dexterity);
            System.Threading.Thread.Sleep(1000);
            WaitAndClear();

            Console.WriteLine("The End....for now");
            WaitAndClear();
            return t;
        }
        #endregion

        #region Core Functions
        private static void ShowStats(string headerText, int strength, int agility, int vitality, int intelligence, int dexterity)
        {
            Console.WriteLine(headerText);
            Console.WriteLine("STRENGTH: " + strength);
            Console.WriteLine("AGILITY: " + agility);
            Console.WriteLine("VITALITY: " + vitality);
            Console.WriteLine("INTELLIGENCE: " + intelligence);
            Console.WriteLine("DEXTERITY: " + dexterity);
        }

        private static void ShowStats(string headerText, RaceObj r)
        {
            ShowStats(headerText, r.STRENGTH, r.AGILITY, r.VITALITY, r.INTELLIGENCE, r.DEXTERITY);
        }

        private static void ShowStats(string headerText, ClassObj c)
        {
            ShowStats(headerText, c.STRModifier, c.AGIModifier, c.VITModifier, c.INTModifier, c.DEXModifier);
        }

        private static void WaitAndClear()
        {
            Console.WriteLine("\r\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion
    }
}
