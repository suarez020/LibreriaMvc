using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LibreriaMvc.Models;


namespace LibreriaMvc.Contexto
{//ojo aca con esta clase 
    public  class LibreriaMvcContext : DbContext
    {
        public DbSet<Cliente>Clientes{ get; set;}
        public DbSet<Autor>Autors { get; set; }
        public DbSet<Libro>Libros { get; set; }
    }
}