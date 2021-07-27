using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static IList<Filme> filmes = new List<Filme>();
        private static int id = 1;
        
        [HttpPost]
        public void AdicionarFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            Console.WriteLine($"Passando no 'AdicionarFilme', o nome do filme é {filme.Titulo}");
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {
            return filmes;
        }

        [HttpGet("{id}")]
        public Filme RecuperarFilmePorId(int id)
        {
            return filmes.FirstOrDefault(filme => filme.Id == id);
        }
    }
}
