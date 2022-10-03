using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassVsStruct
{
    public struct Player
    {
        public int Health{get;set;}
        public int Armor{get;set;}

        public Player(int health, int armor)
        {
            Health = health;
            Armor = armor;
        }
    }
}