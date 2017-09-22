using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int HP { get; set; }

        public Random random = new Random();

        public Weapon Equipped { get; set; }
        public List<Weapon> weaponList;

        public Character(string name, int hp)
        {
            Name = name;
            HP = hp;

            weaponList = new List<Weapon>();
        }

        public void Equip(Weapon weapon)
        {
            if(weaponList.Contains(weapon))
            {
                Equipped = weapon;
            }
        }

        public int DealDamage(int damage)
        {
            return random.Next(0, damage);
        }

        public abstract void ReceiveDamage(int damage);
    }
}
