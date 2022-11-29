using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Creature
    {
        private string _creatureName;
        private int _hp;
        private int _mp;

        public Wizert(string creatureName, int hp, int mp)
        {
            _creatureName = creatureName;
            _hp = hp;
            _mp = mp;
        }

        public Orc(string creatureName, int hp, int mp)
        {
            _creatureName = creatureName;
            _hp = hp;
            _mp = mp;
        }

        public Goblin(string creatureName, int hp, int mp)
        {
            _creatureName = creatureName;
            _hp = hp;
            _mp = mp;
        }

        public Banshee(string creatureName, int hp, int mp)
        {
            _creatureName = creatureName;
            _hp = hp;
            _mp = mp;
        }

        public void Fireball()
        {
            if (_mp <= 0)
            {
                Console.WriteLine("Not enough MP.");
            }
            else
            {
                Console.WriteLine("The Wizert casts a fireball that burns the enemy.");
                _mp -= 3;
            }
        }
        public void Heal()
        {
            if (_mp <= 0)
            {
                Console.WriteLine("Not enough MP.");
            }
            else
            {
                Console.WriteLine("The Wizert casts a spell to heal his wounds.");
                _mp -= 5;
            }
        }

        public void Flee()
        {
            Console.WriteLine("The Wizert attempts to flee from battle.");
        }

        public void TakeDamage()
        {
            _hp--;

            if (_hp <= 0)
            {
                Console.WriteLine($"The Wizert {_creatureName} has died in battle!");
            }
            else
            {
                Console.WriteLine($"The Wizert {_creatureName} has taken damage.");
            }

        }

        public void BodySlam()
        {
            Console.WriteLine("Goblin attacks with a body slam attack.");
            _hp -= 2;
        }

        public void Cleave()
        {
            Console.WriteLine("Orc attacks witha cleave attack.");
            _hp -= 3;
        }

        public void Screech()
        {
            Console.WriteLine("Banshee attacks with a screech.");
            _hp -= 5;
        }

        public void HealthPotion()
        {
            Console.WriteLine("You decide to use a health potion.");
            _hp += 10;
        }

        public void MagicPotion()
        {
            Console.WriteLine("You decide to use a magic potion");
            _mp += 20;
        }
    }
}
