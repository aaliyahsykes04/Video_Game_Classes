using System;
using System.Collections.Generic;
using System.Text;

namespace Video_Game_Classes
{
    internal class Enemy
    {
        //attributes
        public string Type { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public float Speed { get; set; }
        
        public int Level { get; set; }

        // constructor

      public Enemy(string type, int health, int damage, float speed, int level)
        {
            Type = type;
            Health = health;
            Damage = damage;
            Speed = speed;
            Level = level;
        }
        public void Take_damage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }
        public void Attack(Player player)
        {
            player.Take_damage(Damage);
        }
    }
}
