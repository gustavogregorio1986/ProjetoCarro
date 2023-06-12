using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCarroAPI.Dominio.Dominio
{
    [Table("tb_Carro")]
    public class Carro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idcarro { get; set; }

        public string NomeCarro { get; set; }

        public string Marca { get; set; }

        public string Cor { get; set; }

        public string Descricao { get; set; }
    }
}
