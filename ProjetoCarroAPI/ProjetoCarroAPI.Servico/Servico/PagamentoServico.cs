using ProjetoCarroAPI.Data.DTO;
using ProjetoCarroAPI.Data.Repository.Interface;
using ProjetoCarroAPI.Dominio.Dominio;
using ProjetoCarroAPI.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Servico.Servico
{
    public class PagamentoServico : IPagamentoServico
    {
        private readonly IPagamentoRepository pagamentoRepository;

        public void Adicionar(PagamentoDTO pagamentoDTO)
        {
            pagamentoRepository.Adicionar(pagamentoDTO);
        }
    }
}
