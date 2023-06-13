using ProjetoCarroAPI.Data.DTO;
using ProjetoCarroAPI.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroAPI.Servico.Servico.Interface
{
    public interface ICarroServico
    {
        void Adicionar(CarroDTO carroDTO);
    }
}
