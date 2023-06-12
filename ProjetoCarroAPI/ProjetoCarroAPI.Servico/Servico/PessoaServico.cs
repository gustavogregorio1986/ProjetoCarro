using ProjetoCarroAPI.Data.DTO;
using ProjetoCarroAPI.Data.Repository.Interface;
using ProjetoCarroAPI.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Servico.Servico
{
    public class PessoaServico : IPessoaServico
    {
        private readonly IPessoaRepository pessoaRepository;

        public void Adicionar(PessoaDTO pessoaDTO)
        {
            pessoaRepository.Adicionar(pessoaDTO);
        }
    }
}
