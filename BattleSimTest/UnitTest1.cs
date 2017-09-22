using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleSim;

namespace BattleSimTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Wizard wizard = new Wizard("Henk", 200, 500);
            Knight knight = new Knight("Sjonnie", 300, 200);

            Weapon axe = new Weapon("Axe", 20);
            Weapon staff = new Weapon("Staff", 10);

            Spell fireball = new Spell("Fire Ball", 10, 30);

            wizard.SpellList.Add(fireball);

            knight.weaponList.Add(axe);
            wizard.weaponList.Add(staff);

            knight.Equipped = knight.weaponList[0];
            wizard.Equipped = wizard.weaponList[0];

            GameController gc = new GameController(wizard, knight);
            
            gc.Update();
            gc.Update();

            Assert.AreNotEqual(knight.ShieldPower == 200, knight.ShieldPower < 200);
            Assert.AreEqual(knight.HP == 300, true);
            Assert.AreNotEqual(wizard.HP == 200, wizard.HP < 200);
        }
    }
}
