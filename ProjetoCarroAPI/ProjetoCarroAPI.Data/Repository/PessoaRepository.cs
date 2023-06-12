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
    public class PessoaRepository : IPessoaRepository
    {
        private readonly ProjetoCarroAPIContexto projetoCarroAPIContexto;

        public PessoaRepository()
        {
            projetoCarroAPIContexto = new ProjetoCarroAPIContexto();
        }

        public void Adicionar(PessoaDTO pessoaDTO)
        {
            projetoCarroAPIContexto.Add(pessoaDTO);
        }
    }
}
