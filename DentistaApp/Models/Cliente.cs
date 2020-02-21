using System;
using DentistaApp.Models.Enum;

namespace DentistaApp.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public Cidades Cidade { get; set; }

        
    }
}
