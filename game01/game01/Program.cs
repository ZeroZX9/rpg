using game01.Data;
using game01.Data.Repositories;
using game01.Models;
using game01.Models.Creatures;
using System.Runtime.InteropServices;
using System.Text.Json;

var databaseProcessor = new DatabaseProcessor(DatabaseProcessor.Database.File);
var comando = EscolherComando();

while (comando != "Z")
{
    if (comando == "1")
    {
        Console.WriteLine("Qual o nome da Criatura?");
        var nome = Console.ReadLine();
        var creature = new Creature(nome);

        Console.WriteLine("Qual o hp da Criatura?");
        var hp = int.Parse(Console.ReadLine());
        creature.SetHp(hp);

        databaseProcessor.InsertCreature(creature);

    }

    if (comando == "2")
    {
        var creatures = databaseProcessor.GetCreatures();
        foreach (var creature in creatures)
        {
            Console.WriteLine(creature);
        }
    }

    comando = EscolherComando();
}



string EscolherComando()
{
    Console.WriteLine("O que deseja fazer?");

    Console.WriteLine("1 - Criar Criatura ");
    Console.WriteLine("2 - Listar Criaturas ");
    Console.WriteLine("Z - Sair ");
    return Console.ReadLine().ToUpper();
}