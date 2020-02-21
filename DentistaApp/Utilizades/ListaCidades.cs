using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentistaApp.Models.Enum;

namespace DentistaApp.Utilizades
{
    public class ListaCidades
    {
        public static List<String> GetCidades()
        {
            List<String> cidades = Enum.GetValues(typeof(Cidades))
                .Cast<Cidades>()
                .Select(m => m.ToString())
                .ToList();

            return cidades;
        }
    }
}
