using game01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game01.Data.Repositories
{
    internal class CreatureLocalRepository : ICreatureRepository
    {
        public List<Creature> _creatures { get; set; }

        public CreatureLocalRepository()
        {
            _creatures = new List<Creature>();
        }
        public bool Delete(int id)
        {
            var creature = _creatures.FirstOrDefault(x => x.Id == id);
            _creatures.Remove(creature);
            return true;
        }

        public Creature Get(int id)
        {
            return _creatures.FirstOrDefault(creature => creature.Id == id);
        }

        public List<Creature> GetAll()
        {
            return _creatures;
        }

        public bool Insert(Creature creature)
        {
            creature.Id = _creatures.Count() + 1;
            _creatures.Add(creature);
            return true;
        }

        public void Update(Creature creature)
        {
            throw new NotImplementedException();
        }
    }
}
