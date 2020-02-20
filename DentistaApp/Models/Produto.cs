using System;
using System.Collections.Generic;
using System.Linq;
using DentistaApp.Models.Enum;


namespace DentistaApp.Models
{
    public class Produto
    {
        public int Id  { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public Materias Tipo { get; set; }

        public int Estoque { get; set; }

        public Fornecedor Fornecedor { get; set; }

    }
}
