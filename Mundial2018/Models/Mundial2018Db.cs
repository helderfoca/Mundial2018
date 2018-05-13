using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Mundial2018.Models
{
    public class Mundial2018Db : DbContext
    {

        public Mundial2018Db() : base("Mundial2018DbConnectionString")
        {

        }



        // tabelas da base de dados

        public virtual DbSet<Nations> Nations { get; set; }

        public virtual DbSet<Players> Players { get; set; }





        /// <summary>
        /// configura a forma como as tabelas são criadas
        /// </summary>
        /// <param name="modelBuilder">objeto que referencia o gerador de base de dados</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }


    }
}