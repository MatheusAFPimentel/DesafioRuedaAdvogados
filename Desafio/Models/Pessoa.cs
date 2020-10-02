using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Desafio.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public float salario { get; set; }

        public int numeroTelefone { get; set; }
        public virtual Telefone telefone { get; set; }
    }
}