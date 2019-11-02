namespace EF_1x1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tab_produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Descricao = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        ValorCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lucro = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tab_categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tab_produtos", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.tab_estoque",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Atual = c.Int(nullable: false),
                        Minimo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tab_produtos", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tab_estoque", "Id", "dbo.tab_produtos");
            DropForeignKey("dbo.tab_categorias", "ProdutoId", "dbo.tab_produtos");
            DropIndex("dbo.tab_estoque", new[] { "Id" });
            DropIndex("dbo.tab_categorias", new[] { "ProdutoId" });
            DropTable("dbo.tab_estoque");
            DropTable("dbo.tab_categorias");
            DropTable("dbo.tab_produtos");
        }
    }
}
