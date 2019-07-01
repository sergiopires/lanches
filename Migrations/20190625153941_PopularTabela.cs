using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesMac.Migrations
{
    public partial class PopularTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)VALUES('Normal','Lanche feito com ingredientes normais')");
            //migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)VALUES('Natural','Lanche feito com ingredientes integrais e naturais')");

            migrationBuilder.Sql("INSERT INTO Lanches values('Peito de peru','pao e salada','feito no microondas', 10.20,'http://oi50.tinypic.com/wce07d.jpg','http://oi50.tinypic.com/wce07d.jpg',1,1,5)");
            migrationBuilder.Sql("INSERT INTO Lanches values('Torta banana','banana e acucar','feito ao forno', 08.20,'http://oi49.tinypic.com/24uyzac.jpg','http://oi49.tinypic.com/24uyzac.jpg',1,1,6)");
        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
