using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.DataBase
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) : base(options)
        {

        }


        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<NewsLetterEmail> newsLetterEmails { get; set; }
    }
}
