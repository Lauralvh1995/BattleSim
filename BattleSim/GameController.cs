using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class GameController
    {
        public int TurnCount { get; set; }
        public Character ActiveCharacter { get; set; }
        List<Character> characters = new List<Character>();

        public GameController(Character char1, Character char2)
        {
            TurnCount = 1;
            characters.Add(char1);
            characters.Add(char2);
            ActiveCharacter = characters[0];
        }

        public void Update()
        {
            if(ActiveCharacter == characters[0])
            {
                if(ActiveCharacter is Wizard)
                {
                    Wizard wizard = ActiveCharacter as Wizard;
                    wizard.CastSpell(wizard.SpellList[0]);
                }
                if (ActiveCharacter is Knight)
                {
                    Knight knight = ActiveCharacter as Knight;
                    knight.DealDamage(knight.Equipped.Power);
                }
            }
            else
            {
                if (ActiveCharacter is Wizard)
                {
                    Wizard wizard = ActiveCharacter as Wizard;
                    wizard.CastSpell(wizard.SpellList[0]);
                }
                if (ActiveCharacter is Knight)
                {
                    Knight knight = ActiveCharacter as Knight;
                    knight.DealDamage(knight.Equipped.Power);
                }

            }
            PassTurn();
        }

        public void PassTurn()
        {
            TurnCount++;
            if(IsEven(TurnCount))
            {
                ActiveCharacter = characters[1];
            }
            else
            {
                ActiveCharacter = characters[0];
            }
        }
        
        public bool IsEven(int nr)
        {
            if(nr % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
