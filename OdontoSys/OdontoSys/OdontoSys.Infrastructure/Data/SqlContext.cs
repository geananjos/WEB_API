using Microsoft.EntityFrameworkCore;
using OdontoSys.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdontoSys.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
