using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoM2.Models
{
    public class Aluno
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int RA { get; set; }
        public string Senha { get; set; }
        public virtual Curso Curso { get; set; }
    }
}