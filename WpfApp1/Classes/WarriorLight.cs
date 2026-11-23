using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    public class WarriorLight : Warrior
    {
        public WarriorLight(int health) : base(health) { }

        public override void TakeDamage(int damage)
        {
            //получает 80проц урона
            int finalDamage = (int)(damage * 0.8);
            Health -= finalDamage;
            if (Health < 0) Health = 0;
        }
    }
}
