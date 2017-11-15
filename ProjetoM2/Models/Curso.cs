﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoM2.Models
{
    public class Curso
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual List<Materia> Materias { get; set; }
    }
}