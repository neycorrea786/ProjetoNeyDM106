namespace ProjetoNey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProdutoID = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.ProdutoID, cascadeDelete: true)
                .Index(t => t.ProdutoID);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false),
                        cor = c.String(),
                        modelo = c.String(nullable: false),
                        codigo = c.String(nullable: false, maxLength: 8),
                        preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        peso = c.Single(nullable: false),
                        altura = c.Single(nullable: false),
                        largura = c.Single(nullable: false),
                        comprimento = c.Single(nullable: false),
                        diametro = c.Single(nullable: false),
                        URL = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailUser = c.String(nullable: false),
                        dataPedido = c.DateTime(nullable: false),
                        dataEntrega = c.DateTime(nullable: false),
                        status = c.String(),
                        precoTotalPedido = c.Decimal(nullable: false, precision: 18, scale: 2),
                        pesoTotalPedido = c.Single(nullable: false),
                        precoFrete = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ProdutoID", "dbo.Produtoes");
            DropIndex("dbo.Items", new[] { "ProdutoID" });
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Items");
        }
    }
}
