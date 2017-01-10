using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCValadares
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();
            Usuario renan = new Usuario()
            {
                Nome = "Renan",
                Senha = "123"
            };
            contexto.Usuarios.Add(renan);
            contexto.SaveChanges();
            contexto.Dispose();
        }
    }
}
