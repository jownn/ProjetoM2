using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoM2.Models
{
    public class Notas
    {
        public int ID { get; set; }
        public int M1 { get; set; }
        public int M2 { get; set; }
        public int SUB { get; set; }
        public int Previsao { get; set; }
        public int Media { get; set; }
        public virtual Aluno Aluno { get; set; }
        public virtual Materia Materia { get; set; }
    }
}