using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizertFiveGame
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

        public void useMagic()
        {
            if (_mp <= 0)
            {
                Console.WriteLine("Out of magic points.");
            }
            else
            {
                _mp--;
            }
        }

        public void TakeDamage()
        {
            _hp--;

            if (_hp <= 0)
            {
                Console.WriteLine($"The Wizert {_wizertName} has died in battle!");
            }
            else
                Console.WriteLine($"The Wizert {_wizertName} has taken damage.");
        }
    }
}