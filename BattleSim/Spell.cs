using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Spell
    {
        public string Name { get; set; }
        public int ManaCost { get; set; }
        public int Power { get; set; }

        public Spell(string name, int manaCost, int power)
        {
            Name = name;
            ManaCost = manaCost;
            Power = power;
        }
    }
}
