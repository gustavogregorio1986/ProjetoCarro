using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCarroAPI.Dominio.Dominio
{
    [Table("tb_Pessoa")]
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPessoa { get; set; }


        public string NomePessoa { get; set; }

        public string EmailPessoa { get; set; }

        public string Sexo { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public Carro Carro { get; set; }

        [ForeignKey("Carro")]
        public int Id_Carro { get; set; }
    }
}
