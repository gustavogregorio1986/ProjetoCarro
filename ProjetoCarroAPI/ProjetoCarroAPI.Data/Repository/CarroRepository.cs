using Microsoft.EntityFrameworkCore;
using ProjetoCarroAPI.Data.Contexto;
using ProjetoCarroAPI.Data.DTO;
using ProjetoCarroAPI.Data.Repository.Interface;
using ProjetoCarroAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Data.Repository
{
    public class CarroRepository : ICarroRepository
    {
        private readonly ProjetoCarroAPIContexto projetoCarroAPIContexto;

        public CarroRepository()
        {
            projetoCarroAPIContexto = new ProjetoCarroAPIContexto();
        }

        public void Adicionar(CarroDTO carroDTO)
        {
            projetoCarroAPIContexto.Add(carroDTO);
        }
    }
}
