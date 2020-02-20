using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentistaApp.Models.Enum;
namespace DentistaApp.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime Cadastro { get; set; }
        public Materias TipoProduto { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
