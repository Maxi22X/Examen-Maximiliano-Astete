﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
