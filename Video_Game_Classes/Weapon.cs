using System;
using System.Collections.Generic;
using System.Text;

namespace Video_Game_Classes
{
    internal class Weapon
    {
        //attributes
        public string Name { get; set; }
        public int Damage { get; set; }
        public float Range { get; set; }
        public float Speed { get; set; }


        //constructor
        public Weapon(string name, int damage, float range)
        {
            Name = name;
            Damage = damage;
            Range = range;
        }

        publlic void UpgradeDamage(int amount)
        {
            Damage += amount;
        }

        public int Shoot()
        {
            return Damage;
        }


    }
}

