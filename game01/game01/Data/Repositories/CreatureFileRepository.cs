using game01.Models;
using game01.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace game01.Data.Repositories
{
    internal class CreatureFileRepository : ICreatureRepository
    {
        public List<Creature> _creatures { get; set; }
        public CreatureFileRepository()
        {
            _creatures = new List<Creature>();
            var creaturesJson = FileUtils.GetText("files\\creatures", "creatures.txt");
            if (string.IsNullOrEmpty(creaturesJson))
            {
                return;
            }

            _creatures = JsonSerializer.Deserialize<List<Creature>>(creaturesJson);
        }

        public bool Delete(int id)
        {
            var creature = _creatures.FirstOrDefault(x => x.Id == id);
            _creatures.Remove(creature);

            Commit();
            return true;
        }

        public Creature Get(int id)
        {
            return _creatures.FirstOrDefault(x => x.Id == id);
        }

        public List<Creature> GetAll()
        {
            return _creatures;
        }

        public bool Insert(Creature creature)
        {
            creature.Id = _creatures.Count() + 1;
            _creatures.Add(creature);

            Commit();
            return true;
        }

        public void Update(Creature creature)
        {

            var creatureDb = _creatures.FirstOrDefault(x => x.Id == creature.Id);
            if (creatureDb == null)
            {
                return;
            }

            creatureDb.Hp = creature.Hp;
            creatureDb.Xp = creature.Xp;
            creatureDb.Mp = creature.Mp;
            creatureDb.Atk = creature.Atk;
            creatureDb.Def = creature.Def;
            creatureDb.Lvl = creature.Lvl;
            creatureDb.Name = creature.Name;
            creatureDb.Spd = creature.Spd;

            Commit();
        }

        private void Commit()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var creturesJson = JsonSerializer.Serialize(_creatures, options);
            FileUtils.SaveFile(creturesJson, "files/creatures", "creatures.txt");
        }
    }
}
