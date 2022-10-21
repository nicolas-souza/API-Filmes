using API_Filmes.Model;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Filmes.Data
{
    //DbContext é a classe base para utilização do Entity Framework
    public class AppDbContext : DbContext
    {
        //Os parâmetros vem do Starup.cs
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Endereco>()
                .HasOne(endereco => endereco.Cinema)
                .WithOne(cinema => cinema.Endereco)
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId);

            builder.Entity<Cinema>()
                .HasOne(cinema => cinema.Gerente)
                .WithMany(gerente => gerente.Cinemas)
                .HasForeignKey(cinema => cinema.GerenteId);
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Endereco>Enderecos { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }



    }
}

