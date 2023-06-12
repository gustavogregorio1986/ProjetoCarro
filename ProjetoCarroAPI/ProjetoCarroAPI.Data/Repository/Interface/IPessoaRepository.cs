using ProjetoCarroAPI.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Data.Repository.Interface
{
    public interface IPessoaRepository
    {
        void Adicionar(PessoaDTO pessoaDTO);
    }
}
