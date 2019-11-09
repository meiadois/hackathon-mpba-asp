﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HACKA.MEIADOIS.UI.Models
{
    public class Historico
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public string NomeProduto { get; set; }

        public string CategoriaProduto { get; set; }

        public string PrecoProduto { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}