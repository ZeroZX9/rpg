using game01.Data.Repositories;
using game01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game01.Data
{

    internal class DatabaseProcessor
    {
        private ICreatureRepository _creatureRepository;

        internal enum Database
        {
            File,
            Mysql,
            Local
        }

        public DatabaseProcessor(Database database)
        {
            _creatureRepository = database == Database.File ? new CreatureFileRepository() : new CreatureLocalRepository();
        }

        public void InsertCreature(Creature creature)
        {
            _creatureRepository.Insert(creature);
        }

        public List<Creature> GetCreatures()
        {
            return _creatureRepository.GetAll();
        }
    }
}
