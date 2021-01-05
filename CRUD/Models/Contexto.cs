using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace CRUD.Models
{
    //Faz a conexão com o banco
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}