using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoCarroAPI.Data.Migrations
{
    public partial class dr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Carro",
                columns: table => new
                {
                    Idcarro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCarro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Carro", x => x.Idcarro);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pessoa",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailPessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Carro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pessoa", x => x.IdPessoa);
                    table.ForeignKey(
                        name: "FK_tb_Pessoa_tb_Carro_Id_Carro",
                        column: x => x.Id_Carro,
                        principalTable: "tb_Carro",
                        principalColumn: "Idcarro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    QtdeServicos = table.Column<int>(type: "int", nullable: false),
                    Id_Pessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pagamento", x => x.IdPagamento);
                    table.ForeignKey(
                        name: "FK_tb_Pagamento_tb_Pessoa_Id_Pessoa",
                        column: x => x.Id_Pessoa,
                        principalTable: "tb_Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pagamento_Id_Pessoa",
                table: "tb_Pagamento",
                column: "Id_Pessoa");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pessoa_Id_Carro",
                table: "tb_Pessoa",
                column: "Id_Carro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Pagamento");

            migrationBuilder.DropTable(
                name: "tb_Pessoa");

            migrationBuilder.DropTable(
                name: "tb_Carro");
        }
    }
}
