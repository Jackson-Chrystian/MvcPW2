using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class DBContext : DbContext
    {
        //comando "ctor" + tecla TAB 2 vezes.
        //Gera o método construtor.
        public DBContext() : base("Aluno")
        {

        }

        //comando "prop" + tecla TAB 2 vezes.
        public DbSet<Aluno> Alunos { get; set; }

        //comando "override" + tecla espaço (processo de herança).
        //Gera o processo de herança.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}