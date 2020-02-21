using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DentistaApp.Models;

namespace DentistaApp.Controllers
{
    public class HomeController : Controller
    {
        private DentistaAppContext _context;

        public HomeController(DentistaAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ClienteBuscaResult> clientes = new List<ClienteBuscaResult>();

            foreach(Cliente c in _context.Cliente.ToList())
            {
                clientes.Add(new ClienteBuscaResult()
                {
                    Cliente = c,
                    CidadeName = c.Cidade.ToString()
                });
            }

            ViewData["Clientes"] = clientes;
            ViewData["Dentistas"] = _context.Dentista.ToList();
            ViewData["Fornecedores"] = _context.Fornecedor.ToList();
            ViewData["Produtos"] = _context.Produto.ToList();

            return View();
        }
      


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
