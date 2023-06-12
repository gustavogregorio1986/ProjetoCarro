using ProjetoCarroAPI.Data.Contexto;
using ProjetoCarroAPI.Data.DTO;
using ProjetoCarroAPI.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Data.Repository
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly ProjetoCarroAPIContexto projetoCarroAPIContexto;

        public PagamentoRepository()
        {
            projetoCarroAPIContexto = new ProjetoCarroAPIContexto();
        }

        public void Adicionar(PagamentoDTO pagamentoDTO)
        {
            projetoCarroAPIContexto.Add(pagamentoDTO);
        }
    }
}
