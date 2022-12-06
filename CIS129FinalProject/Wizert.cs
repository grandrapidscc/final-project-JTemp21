using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Wizert
    {
        private string _wizertName;
        private int _hp;
        private int _mp;

        public Wizert(string wizertName, int hp, int mp)
        {
            _wizertName = wizertName;
            _hp = hp;
            _mp = mp;
        }

        public void Magic(int action)
        {
            //switch statement
            void Fireball()
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
            void Heal()
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

            void Flee()
            {
                Console.WriteLine("The Wizert attempts to flee from battle.");
            }

            void TakeDamage()
            {
                _hp--;

                if (_hp <= 0)
                {
                    Console.WriteLine($"The Wizert {_wizertName} has died in battle!");
                }
                else
                {
                    Console.WriteLine($"The Wizert {_wizertName} has taken damage.");
                }

            }
        }
    }
}
