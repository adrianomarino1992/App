using DentistaApp.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistaApp.Utilizades
{
    public static class ListarMaterias
    {
        public  static List<String> GetMaterias()
        {
            List<String> materias = Enum.GetValues(typeof(Materias))
                .Cast<Materias>()
                .Select(m => m.ToString())
                .ToList();

            return materias;
        }
                
    }
}
