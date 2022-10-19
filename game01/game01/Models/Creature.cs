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
        public void SetMp(int mp)
        {
            Mp = mp;
        }
        public void SetDef(int def)
        {
            Def = def;
        }
        public void SetAtk(int atk)
        {
            Atk = atk;
        }
        public void SetSpd(int spd)
        {
            Spd = spd;
        }
        public void SetXp(int xp)
        {
            Xp = xp;
        }
        public override string ToString()
        {
            return $"Id: {Id} - Nome: {Name} - Hp: {Hp}";
        }

        public virtual void TomarGolpe(int dano)
        {
            if (dano <= 0)
            {
                dano = 0;
            }
            else 
            {
                Hp -= (dano - Def);
            }
        }
    }
}
