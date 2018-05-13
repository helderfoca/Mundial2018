namespace Mundial2018.Migrations
{
    using Mundial2018.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mundial2018.Models.Mundial2018Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Mundial2018.Models.Mundial2018Db context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            //*********************************************************************
            // adiciona Seleções
            var nations = new List<Nations> {
                new Nations {ID=1, Name="Portugal"},
                new Nations {ID=1, Name="Spain"},
                new Nations {ID=1, Name="England"},
                new Nations {ID=1, Name="Germany"}
            };
            nations.ForEach(aa => context.Nations.AddOrUpdate(a => a.Name, aa));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Componentes
            var players = new List<Players> {
                new Players {ID=1, Name="Cristiano Ronaldo", BirthDate=new DateTime(1990,01,14), Position="Foward", NationFK=1 },
                new Players {ID=1, Name="Rui Patricio", BirthDate=new DateTime(1994,01,14), Position="Goal Keeper", NationFK=1 }
            };
            players.ForEach(aa => context.Players.AddOrUpdate(a => a.Name, aa));
            context.SaveChanges();


        }
    }
}
