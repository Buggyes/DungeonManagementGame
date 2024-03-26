using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Management_Game
{
    public enum MinionType
    {
        skeleton, imp, golem, gargoyle, wraith, fishman
    }
    public class Minion
	{
        public float maximumHealth { get; private set; }
        public float currentHealth { get; private set; }
        public float damage { get; private set; }
        public double salary { get; set; }
        public MinionType type { get; private set; }
        public Minion(float maximumHealth, float damage, MinionType type, double salary)
        {
            this.maximumHealth = maximumHealth;
            this.damage = damage;
            this.type = type;
            this.salary = salary;
        }
	}
}
