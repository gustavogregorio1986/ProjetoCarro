using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCarroAPI.Dominio.Dominio
{
    [Table("tb_Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPagamento { get; set; }

        public double Preco { get; set; }

        public int QtdeServicos { get; set; }

        public Pessoa Pessoa { get; set; }

        [ForeignKey("Pessoa")]
        public int Id_Pessoa { get; set; }
    }
}
