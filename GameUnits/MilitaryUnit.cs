using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit: Unit
    {
        public override int Health => base.Health + XP ;

        public override float Value => AttackPower + XP;

        public int AttackPower{get;}

        public int XP{get;set;}
        public MilitaryUnit(int movement, int health, int attackpower)
        : base(movement, health)
        {
            AttackPower = attackpower;
            XP = 0;

        }

        public void Attack(Unit u)
        {

        }


    }
}