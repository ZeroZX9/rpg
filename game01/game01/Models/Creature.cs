using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game01.Models
{
    internal class Creature
    {
        public int Id { get; set; }
        private string Name { get; set; }
        private int Hp { get; set; }
        private int Def { get; set; }
        private int Mp { get; set; }
        private int Atk { get; set; }
        private int Spd { get; set; }
        private int Xp { get; set; }
        private int Lvl { get; set; }

        public Creature()
        {
        }

        public Creature(string name)
        {
            Name = name;
        }

        public void SetHp(int hp)
        {
            Hp = hp;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Nome: {Name} - Hp: {Hp}";
        }

        public virtual void TomarGolpe(int dano)
        {
            Hp -= dano;
        }
    }
}
