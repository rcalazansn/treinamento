namespace Mercadinho.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tab_clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Nascimento = c.DateTime(nullable: false),
                        UltimaCompra = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.tab_produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        ValorCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lucro = c.Int(nullable: false),
                        ValorVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tab_fornecedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataRecebimento = c.DateTime(),
                        QuantidadeRecebimento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tab_estoque", "Id", "dbo.tab_produtos");
            DropIndex("dbo.tab_estoque", new[] { "Id" });
            DropTable("dbo.tab_fornecedores");
            DropTable("dbo.tab_produtos");
            DropTable("dbo.tab_estoque");
            DropTable("dbo.tab_clientes");
        }
    }
}
