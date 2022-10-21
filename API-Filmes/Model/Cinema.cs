﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Filmes.Model
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        
        public int GerenteId { get; set; }
        public int EnderecoId { get; set; }
        
        public virtual Gerente Gerente { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
