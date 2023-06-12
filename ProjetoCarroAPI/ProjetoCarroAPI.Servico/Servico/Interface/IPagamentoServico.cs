using ProjetoCarroAPI.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Servico.Servico.Interface
{
    public interface IPagamentoServico
    {
        void Adicionar(PagamentoDTO pagamentoDTO);
    }
}
