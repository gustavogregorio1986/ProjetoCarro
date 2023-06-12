using ProjetoCarroAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Data.DTO
{
    public class CarroDTO
    {
        public int IdCarroDTO { get; set; }

        public string NomeMarcaDTO { get; set; }

        public string marcaDTO { get; set; }

        public string CorDTO { get; set; }

        public string DescricaoDTO { get; set; }

        public CarroDTO(Carro carro)
        {
            this.IdCarroDTO = carro.Idcarro;
            this.NomeMarcaDTO = carro.NomeCarro;
            this.marcaDTO = carro.Marca;
            this.CorDTO = carro.Cor;
            this.DescricaoDTO = carro.Descricao;
        }

        public CarroDTO()
        {

        }
    }
}
