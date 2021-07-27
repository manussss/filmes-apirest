﻿using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext
    {

        public DbSet<Filme> Filmes { get; set; }

        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
        {

        }
    }
}
