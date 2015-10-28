namespace SuperHeroeFinder.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MarvelCharacterService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SuperHeroContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SuperHeroContext context)
        {
            context.CharacterTypes.AddOrUpdate(x =>
                x.Name,
                new CharacterType { Name = "Hero" },
                new CharacterType { Name = "Villian" },
                new CharacterType { Name = "Goes Both Ways" }
                );

            context.SaveChanges();

            context.Characters.AddOrUpdate(x =>
                x.Name, new Character
                {
                    Name = "Wolverine",
                    NumberOfComics = 1794,
                    NumberOfSeries = 436,
                    CharacterType = context.CharacterTypes.FirstOrDefault(x => x.Name == "Hero"),
                    ProfilePage = "http://marvel.com/characters/66/wolverine?utm_campaign=apiRef&utm_source=a346c95988e8d81ce986d98fbd99033a"
                },
            new Character
            {
                Name = "Cyclops",
                NumberOfComics = 697,
                NumberOfSeries = 214,
                CharacterType = context.CharacterTypes.FirstOrDefault(x => x.Name == "Hero"),
                ProfilePage = "http://marvel.com/characters/10/cyclops?utm_campaign=apiRef&utm_source=a346c95988e8d81ce986d98fbd99033a"
            },
            new Character
            {
                Name = "Loki",
                NumberOfComics = 187,
                NumberOfSeries = 77,
                CharacterType = context.CharacterTypes.FirstOrDefault(x => x.Name == "Villian"),
                ProfilePage = "http://marvel.com/characters/33/loki?utm_campaign=apiRef&utm_source=a346c95988e8d81ce986d98fbd99033a"
            },
            new Character
            {
                Name = "SpiderMan",
                NumberOfComics = 2575,
                NumberOfSeries = 531,
                CharacterType = context.CharacterTypes.FirstOrDefault(x => x.Name == "Hero"),
                ProfilePage = "http://marvel.com/characters/54/spider-man?utm_campaign=apiRef&utm_source=a346c95988e8d81ce986d98fbd99033a"
            },
            new Character
            {
                Name = "Magneto",
                NumberOfComics = 249,
                NumberOfSeries = 111,
                CharacterType = context.CharacterTypes.FirstOrDefault(x => x.Name == "Goes Both Ways"),
                ProfilePage = "http://marvel.com/characters/35/magneto?utm_campaign=apiRef&utm_source=a346c95988e8d81ce986d98fbd99033a"
            }
            );

        }
    }
}
