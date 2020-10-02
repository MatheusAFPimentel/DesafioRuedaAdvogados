using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Desafio.Models
{
    public class Telefone
    {
        [Key]
        public int idTelefone { get; set; }
        public int numero { get; set; }
    }
}