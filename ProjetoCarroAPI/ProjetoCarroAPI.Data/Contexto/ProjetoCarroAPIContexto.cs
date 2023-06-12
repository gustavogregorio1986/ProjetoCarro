using Microsoft.EntityFrameworkCore;
using ProjetoCarroAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Data.Contexto
{
    public class ProjetoCarroAPIContexto : DbContext
    {
        public ProjetoCarroAPIContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Carro> Carros { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}
