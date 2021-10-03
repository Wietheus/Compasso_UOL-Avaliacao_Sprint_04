using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace API_Rest_Pokemon.Models
{
    public class Pokemon
    {
        public int Codigo { get; set; }
        [Required(ErrorMessage = "Você precisa preencher um nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Você precisa informar o tipo!")]
        public string Tipo { get; set; }
    }
}