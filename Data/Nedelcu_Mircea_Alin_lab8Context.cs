using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nedelcu_Mircea_Alin_lab8.Models;

namespace Nedelcu_Mircea_Alin_lab8.Data
{
    public class Nedelcu_Mircea_Alin_lab8Context : DbContext
    {
        public Nedelcu_Mircea_Alin_lab8Context (DbContextOptions<Nedelcu_Mircea_Alin_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Nedelcu_Mircea_Alin_lab8.Models.Book> Book { get; set; }

        public DbSet<Nedelcu_Mircea_Alin_lab8.Models.Publisher> Publisher { get; set; }
    }
}
