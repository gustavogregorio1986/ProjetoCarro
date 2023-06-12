using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoCarroAPI.Data.DTO;
using ProjetoCarroAPI.Dominio.Dominio;
using ProjetoCarroAPI.Servico.Servico.Interface;

namespace ProjetoCarroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {

        private readonly ICarroServico carroServico;
        private readonly IPessoaServico pessoaServico;
        private readonly IPagamentoServico pagamentoServico;

        public CarroController(ICarroServico carroServico, IPessoaServico pessoaServico, IPagamentoServico pagamentoServico)
        {
            this.carroServico = carroServico;
            this.pessoaServico = pessoaServico;
            this.pagamentoServico = pagamentoServico;
        }

        [HttpPost]
        public JsonResult Cadastro([FromBody] Pagamento pagamento)
        {
            PagamentoDTO pagamentoDTO = new PagamentoDTO();
            pagamento.Preco = pagamentoDTO.PrecoDTO;
            pagamento.QtdeServicos = pagamentoDTO.QtdeComprasDTO;
            pagamento.Pessoa = new Pessoa();
            pagamento.Pessoa.NomePessoa = pagamentoDTO.PessoaDTO.NomePessoaDTO;
            pagamento.Pessoa.EmailPessoa = pagamentoDTO.PessoaDTO.EmailPessoaDTO;
            pagamento.Pessoa.Sexo = pagamentoDTO.PessoaDTO.SexoDTO;
            pagamento.Pessoa.Cpf = pagamentoDTO.PessoaDTO.CpfDTO;
            pagamento.Pessoa.Telefone = pagamentoDTO.PessoaDTO.TelefoneDTO;
            pagamento.Pessoa.Carro = new Carro();
            pagamento.Pessoa.Carro.NomeCarro = pagamentoDTO.PessoaDTO.CarroDTO.NomeMarcaDTO;
            pagamento.Pessoa.Carro.Marca = pagamentoDTO.PessoaDTO.CarroDTO.marcaDTO;
            pagamento.Pessoa.Carro.Cor = pagamentoDTO.PessoaDTO.CarroDTO.CorDTO;
            pagamento.Pessoa.Carro.Descricao = pagamentoDTO.PessoaDTO.CarroDTO.DescricaoDTO;

            return new JsonResult(pagamentoDTO);
        }
    }
}
