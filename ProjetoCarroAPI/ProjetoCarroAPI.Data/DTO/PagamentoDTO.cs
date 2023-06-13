using ProjetoCarroAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Data.DTO
{
    public class PagamentoDTO
    {
        public int IdPagamentoDTO { get; set; }

        public double PrecoDTO { get; set; }

        public int QtdeComprasDTO { get; set; }

        public PessoaDTO PessoaDTO { get; set; }


        public PagamentoDTO()
        {

        }

        public PagamentoDTO(Pagamento pagamento)
        {
            this.IdPagamentoDTO = pagamento.IdPagamento;
            this.PrecoDTO = pagamento.Preco;
            this.QtdeComprasDTO = pagamento.QtdeServicos;
        }
    }
}
