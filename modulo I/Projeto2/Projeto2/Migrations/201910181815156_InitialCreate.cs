namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tab_bancos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 10, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tab_conta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Agencia = c.String(nullable: false, maxLength: 4, unicode: false),
                        ContaCorrente = c.String(nullable: false, maxLength: 10, unicode: false),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Limite = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClienteId = c.Int(nullable: false),
                        BancoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tab_bancos", t => t.BancoId, cascadeDelete: true)
                .ForeignKey("dbo.tab_clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.BancoId);
            
            CreateTable(
                "dbo.tab_clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeTitular = c.String(nullable: false, maxLength: 60, unicode: false),
                        Nascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tab_conta", "ClienteId", "dbo.tab_clientes");
            DropForeignKey("dbo.tab_conta", "BancoId", "dbo.tab_bancos");
            DropIndex("dbo.tab_conta", new[] { "BancoId" });
            DropIndex("dbo.tab_conta", new[] { "ClienteId" });
            DropTable("dbo.tab_clientes");
            DropTable("dbo.tab_conta");
            DropTable("dbo.tab_bancos");
        }
    }
}
