using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game01.Models
{
    internal class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreateTs { get; set; }
        public DateTime UpdateTs { get; set; }
    }
}
