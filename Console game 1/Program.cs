using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_game_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var rand = new Random();

            var ListOfWeapons = new List<string>() { "FISTS", "Axe", "Sword", "Mace" };
            Console.WriteLine("First victim:");
            var User = new Player(p.Name(), p.HitPoints(), p.WeaponOfChoice(ListOfWeapons));
            Console.WriteLine("Second victim:");
            var User2 = new Player(p.Name(), p.HitPoints(), p.WeaponOfChoice(ListOfWeapons));

            //Tells the information of the first victim
            p.VictimInfo(User.Name, User.HitPoints, ListOfWeapons[User.WeaponOfChoice]);

            var ContinueCount = 0;
            do
            {
                for (int i = 0; i <1 && ContinueCount < 3; i++)
                {
                    p.Continue();
                    ContinueCount++;
                }

                User.HitPoints = p.RemainingHP(User.HitPoints, p.HitOrMiss(rand), p.Damage(rand, User.WeaponOfChoice), ListOfWeapons[User.WeaponOfChoice]);

                if (User.HitPoints <= 0)
                {
                    break;
                }
            } while (User.HitPoints > 0);
            Console.WriteLine("OH GOD! YOU KILLED HIM!!@!@!@!");
            p.Continue();

            p.VictimInfo(User2.Name, User2.HitPoints, ListOfWeapons[User2.WeaponOfChoice]);
            Console.ReadLine();
            Console.WriteLine("{0} ran away while you were fighting {1}", User2.Name, User.Name);
        }


        public string Name()
        {
            Console.WriteLine("What is your victims name?");
            var Name = Console.ReadLine();
            return Name;
        } // Gets the Player's name
        public int HitPoints()
        {
            Console.WriteLine("How many hit points does he have?");
            var HitPoints = Convert.ToInt32(Console.ReadLine());
            while (HitPoints <= 0)
            {
                Console.WriteLine("Are you trying to pick a dead person? Please choose a living person");
                HitPoints = Convert.ToInt32(Console.ReadLine());
            }

            return HitPoints;
        } // Gets the Player's HP
        public int WeaponOfChoice(List<string> ListOfWeapons)
        {
            Console.WriteLine("Pick a weapon of choice:");
            for (int i = 1; i < ListOfWeapons.Count; i++)
            {
                Console.Write("{0} - {1} ", i, ListOfWeapons[i]);
            }
            Console.WriteLine();
            var WeaponPick = Convert.ToInt32(Console.ReadLine());
            if (WeaponPick < 0 || WeaponPick >= 4)
            {
                Console.WriteLine("You have failed to pick a decent weapon");
                WeaponPick = 0;
            }

            return WeaponPick;
        } // Gets the Player's weapons of choice number from the list of weapons
        public void VictimInfo(string Name, int HP, string Weapon) // Provides the information about the Player
        {
            Console.WriteLine("You have picked {0} who has {1} hitpoints and you are using {2} to fight him", Name, HP, Weapon);
        }

        public bool HitOrMiss(Random rand)
        {
            var Hit = true;
            var Chance = rand.Next(20);
            if (Chance >= 8)
            {
                Hit = true;
            }
            else
            {
                Hit = false;
            }

            return Hit;

        } // Decides if you hit or miss
        public int Damage(Random rand, int Weapon)
        {
            var Damage = rand.Next(0, Weapon + 3);
            return Damage;
        } // Decides how much damage you do

        public int RemainingHP(int HP, bool Hit, int Damage, string Weapon)
        {
            var RemainingHP = HP;
            if (Hit == true)
            {
                RemainingHP -= Damage;
                Console.WriteLine("You hit with the {0} for {1} damage, the victim has {2} HP remaining", Weapon, Damage, RemainingHP);
            }
            else
            {
                //RemainingHP++;
                Console.WriteLine("You missed him!");
            }
            return RemainingHP;

        } // Counts the remaining HP after the battle
        public bool Continue()
        {
            var Continue = true;
            Console.WriteLine("Do you wish to continue? Y/N");
            var Answer = Console.ReadLine();
            if (Answer == "Y" || Answer == "y")
            {

                Continue = true;
            }
            else
            {
                Console.WriteLine("It is too late to quit now");
                Continue = true;
            }

            return Continue;
        } // Asks if you wish to continue the fight
    }

    class Player
    {
        public string Name;
        public int HitPoints;
        public int WeaponOfChoice;
        public Player(string name, int hitPoints, int weaponOfChoice)
        {
            Name = name;
            HitPoints = hitPoints;
            WeaponOfChoice = weaponOfChoice;
        }

    }
}
