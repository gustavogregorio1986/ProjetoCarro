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
    public class CarroServico : ICarroServico
    {
        private readonly ICarroRepository carroRepository;

        public void Adicionar(CarroDTO carroDTO)
        {
            carroRepository.Adicionar(carroDTO);
        }
    }
}
