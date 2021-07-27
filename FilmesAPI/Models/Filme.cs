﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo títutlo é obrigatório")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "O campo Diretor é obrigatório")]
        public string Diretor { get; set; }
        
        public string Genero { get; set; }
        
        [Range(1, 600, ErrorMessage = "A durãção deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
