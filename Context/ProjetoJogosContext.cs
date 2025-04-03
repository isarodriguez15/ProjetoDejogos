﻿using Microsoft.EntityFrameworkCore;
using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Context
{
    public class ProjetoJogosContext : DbContext
    {
            public ProjetoJogosContext() { }
            public ProjetoJogosContext(DbContextOptions<ProjetoJogosContext> options): base(options)
            {
            }
            public DbSet<Jogo>? Jogos { get; set; }

            public DbSet<Usuarios>? Usuarios { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server= DESKTOP-A2J49GH\\SQLEXPRESS; Database=ProjetoDeJogos; User Id = sa; Pwd= Senai@134; TrustServerCertificate=true;");
                }
            }
    }
}



