using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game01.Models
{
    internal class Items
    {
        public int Id { get; set; }
        private string Name { get; set; }
        private int DefValue { get; set; }
        private int MpValue { get; set; }
        private int AtkValue { get; set; }
        private int SpdValue { get; set; }
        private string Desc { get; set; }

        public Items(string name)
        {
            Name = name;
        }
    }
}
