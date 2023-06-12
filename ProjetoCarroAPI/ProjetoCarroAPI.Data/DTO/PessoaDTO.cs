using ProjetoCarroAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Data.DTO
{
    public class PessoaDTO
    {
        public int IdPessoaDTO { get; set; }

        public string NomePessoaDTO { get; set; }

        public string EmailPessoaDTO { get; set; }

        public string SexoDTO { get; set; }

        public string CpfDTO { get; set; }

        public string TelefoneDTO { get; set; }

        public CarroDTO CarroDTO { get; set; }

        public int Id_CarroDTO { get; set; }


        public PessoaDTO(Pessoa pessoa)
        {
            this.IdPessoaDTO = pessoa.IdPessoa;
            this.NomePessoaDTO = pessoa.NomePessoa;
            this.EmailPessoaDTO = pessoa.EmailPessoa;
            this.SexoDTO = pessoa.Sexo;
            this.CpfDTO = pessoa.Cpf;
            this.TelefoneDTO = pessoa.Telefone;
        }

        public PessoaDTO()
        {

        }
    }
}
