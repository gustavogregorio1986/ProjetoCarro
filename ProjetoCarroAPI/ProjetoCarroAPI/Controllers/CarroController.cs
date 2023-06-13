using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoCarroAPI.Data.DTO;
using ProjetoCarroAPI.Dominio.Dominio;
using ProjetoCarroAPI.Servico.Servico;
using ProjetoCarroAPI.Servico.Servico.Interface;

namespace ProjetoCarroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {

        private readonly CarroServico carroServico;
        private readonly PessoaServico pessoaServico;
        private readonly PagamentoServico pagamentoServico;

        public CarroController(CarroServico carroServico, PessoaServico pessoaServico, PagamentoServico pagamentoServico)
        {
            this.carroServico = carroServico;
            this.pessoaServico = pessoaServico;
            this.pagamentoServico = pagamentoServico;
        }

        [HttpPost]
        public JsonResult Cadastro([FromBody] Pagamento pagamento)
        {
            PagamentoDTO pagamentoDTO = new PagamentoDTO();
            PessoaDTO pessoaDTO = new PessoaDTO();
            pagamento.Pessoa = new Pessoa();
            CarroDTO carroDTO = new CarroDTO();
            pagamento.Pessoa.Carro = new Carro();
            pagamentoDTO.PrecoDTO = pagamento.Preco;
            pagamentoDTO.QtdeComprasDTO = pagamento.QtdeServicos;
            pessoaDTO.NomePessoaDTO = pagamento.Pessoa.NomePessoa;
            pessoaDTO.EmailPessoaDTO = pagamento.Pessoa.EmailPessoa;
            pessoaDTO.SexoDTO = pagamento.Pessoa.Sexo;
            pessoaDTO.CpfDTO = pagamento.Pessoa.Cpf;
            pessoaDTO.TelefoneDTO = pagamento.Pessoa.Telefone;
            carroDTO.NomeMarcaDTO = pagamento.Pessoa.Carro.NomeCarro;
            carroDTO.marcaDTO = pagamento.Pessoa.Carro.Marca;
            carroDTO.CorDTO = pagamento.Pessoa.Carro.Cor;
            carroDTO.DescricaoDTO = pagamento.Pessoa.Carro.Descricao;
            carroServico.Adicionar(carroDTO);
            pessoaServico.Adicionar(pessoaDTO);
            pagamentoServico.Adicionar(pagamentoDTO);
            return new JsonResult(pagamentoDTO);
        }
    }
}
