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
            PessoaDTO pessoaDTO = new PessoaDTO();
            pagamento.Pessoa = new Pessoa();
            CarroDTO carroDTO = new CarroDTO();
            pagamento.Pessoa.Carro = new Carro();
            return new JsonResult(pagamentoDTO);
        }
    }
}
