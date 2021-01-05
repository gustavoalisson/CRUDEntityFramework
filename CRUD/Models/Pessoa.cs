using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Pessoa
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}