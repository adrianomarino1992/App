using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentistaApp.Data;
using DentistaApp.Models;

namespace DentistaApp.Data
{

    public class IniciarBancoDev
    {
        private DentistaAppContext _context;

        public IniciarBancoDev(DentistaAppContext context)
        {
            _context = context;
        }

        public void Inicializa()
        {
            if(_context.Fornecedor.Any() || _context.Produto.Any())
            {
                return;
            }

            Fornecedor f1 = new Fornecedor()
            {
                Id = 1,
                Cadastro = new DateTime(2019, 05, 20),
                Nome = "STV limitada",
                TipoProduto = Models.Enum.Materias.Alimentos
            };

            Fornecedor f2 = new Fornecedor()
            {
                Id = 2,
                Cadastro = new DateTime(2019, 08, 22),
                Nome = "UI Materias",
                TipoProduto = Models.Enum.Materias.Descartaveis
            };

            Produto p1 = new Produto()
            {
                Id = 1,
                Nome = "Barra de Cereais",
                Descricao = "Barra de cereias integral",
                Estoque = 10,
                Tipo = Models.Enum.Materias.Alimentos,
                Fornecedor = f1
            };

            Produto p2 = new Produto()
            {
                Id = 2,
                Nome = "Luvas",
                Descricao = "Luvas cirurgicas",
                Estoque = 500,
                Tipo = Models.Enum.Materias.Descartaveis,
                Fornecedor = f2
            };

            Produto p3 = new Produto()
            {
                Id = 3,
                Nome = "Balas",
                Descricao = "Balas de Caramelo",
                Estoque = 250,
                Tipo = Models.Enum.Materias.Alimentos,
                Fornecedor = f1
            };


            Cliente c1 = new Cliente() { Cidade = Models.Enum.Cidades.Jacarei, Id = 1, Nome = "Adriano Marino Balera" };

            Dentista d1 = new Dentista() { Nome = "Adriano Balera Marino", Id = 99, Senha = "123", Usuario = "1625" };



            _context.Fornecedor.AddRange(f1, f2);
            _context.Produto.AddRange(p1, p2, p3);
            _context.Cliente.Add(c1);
            _context.Dentista.Add(d1);

            _context.SaveChanges();

        }

    }
}
