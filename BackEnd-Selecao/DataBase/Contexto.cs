using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd_Selecao.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Selecao.DataBase
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Enfermeiro> Enfermeiros { get; set; } 
        public DbSet<Hospital> Hospitals { get; set; }
    }
}
