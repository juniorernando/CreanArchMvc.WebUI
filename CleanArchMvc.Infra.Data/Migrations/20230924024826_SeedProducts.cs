using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Caderno espiral', 'Caderno espiral 100 folhas', 7.45, 50, 'caderno1.jpg', 1)");
            
            mb.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Estojo escolar', 'Estojo escolar cinza', 5.45, 50, 'estojo1.jpg', 1)");

            mb.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Pen drive', 'Pen drive 8GB', 18.45, 50, 'pendrive1.jpg', 2)");

            mb.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) VALUES ('Mouse', 'Mouse sem fio', 22.45, 50, 'mouse1.jpg', 2)");
        
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");            
        }
    }
}
