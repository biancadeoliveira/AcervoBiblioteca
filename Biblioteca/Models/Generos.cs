using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Generos
    {
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Descricao")]
        public string descricao { get; set; }

    }
}
