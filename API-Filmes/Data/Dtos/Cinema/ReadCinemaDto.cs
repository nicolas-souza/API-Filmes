﻿using API_Filmes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Filmes.Data.Dtos.Cinema
{
    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        public API_Filmes.Model.Endereco Endereco { get; set; }
        public Gerente Gerente { get; set; }
    }
}
