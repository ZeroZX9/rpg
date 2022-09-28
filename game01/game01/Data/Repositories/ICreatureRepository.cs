using game01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game01.Data.Repositories
{
    internal interface ICreatureRepository
    {
        bool Insert(Creature creature);
        bool Delete(int id);
        void Update(Creature creature);
        Creature Get(int id);
        List<Creature> GetAll();
    }
}
