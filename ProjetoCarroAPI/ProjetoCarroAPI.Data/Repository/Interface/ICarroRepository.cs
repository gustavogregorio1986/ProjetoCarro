using ProjetoCarroAPI.Data.DTO;
using ProjetoCarroAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Data.Repository.Interface
{
    public interface ICarroRepository
    {
        void Adicionar(CarroDTO carroDTO);
    }
}
