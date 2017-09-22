using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Knight : Character
    {
        public int ShieldPower { get; set; }
        public Knight(string name, int hp, int shieldPower) : base(name, hp)
        {
            Name = name;
            HP = hp;
            ShieldPower = shieldPower;
        }

        public override void ReceiveDamage(int damage)
        {
            if(ShieldPower != 0)
            {
                ShieldPower = ShieldPower - damage;
                if(ShieldPower < 0)
                {
                    HP = HP - Math.Abs(ShieldPower);
                    ShieldPower = 0;
                }
            }
            else
            {
                HP = HP - damage;
            }
        }
    }
}
