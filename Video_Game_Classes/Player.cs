using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_homework
{
    internal class Player
    {
        //attributes
        public int Health { get; set; }
        public string Name { get; set; }
        public List<string> Inventory { get; set; }


        //constructor
        public Player(string name)
        {
            Name = name;
            Health = 100;
            Inventory = new List<string>();
        }

        public void Take_damage(int damage)
        //void --> does not return any value
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public Projectile Shoot(string projectileType)
        {
            return new Projectile(projectileType);
        }
    }

    public class Projectile
    {
        public string Type { get; set; }
        public Projectile(string type)
        {
            Type = type;
        }
    }
}