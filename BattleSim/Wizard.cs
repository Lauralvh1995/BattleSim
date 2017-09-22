using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Wizard : Character
    {
        public int Mana { get; set; }
        public List<Spell> SpellList { get; set; }
        public Wizard(string name, int hp, int mana) : base(name, hp)
        {
            Name = name;
            HP = hp;
            Mana = mana;
            SpellList = new List<Spell>();
        }

        public override void ReceiveDamage(int damage)
        {
            HP = HP - damage;
        }

        public void CastSpell(Spell spell)
        {
            if(Mana >= spell.ManaCost)
            {
                Mana = Mana - spell.ManaCost;
                DealDamage(spell.Power);
            }
            else
            {
                DealDamage(Equipped.Power);
            }
        }
    }
}
