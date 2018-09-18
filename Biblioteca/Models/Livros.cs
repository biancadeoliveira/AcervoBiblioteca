using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Biblioteca.Models
{
    public class Livros
    {
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Resenha do livro")]
        public string resenha { get; set; }

        [Display(Name = "Ano de lançamento: ")]
        [DataType(DataType.Date)]
        public DateTime anoLanc { get; set; }

        [Display(Name = "Gênero")]
        public int genero { get; set; }

        [Display(Name = "Autor")]
        public int autor { get; set; }


        //Função que insere uma obra no banco de dados
        public void Insert(Array v)
        {
//            nome = v[0];

            //Monta a query de inclusão no banco
            string query = string.Format("insert into livros values ('{0}','{1}','{2}')", nome, resenha, anoLanc);
        }



    }
}
