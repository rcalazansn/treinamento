namespace Mercadinho.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tab_fornecedores", "QuantidadeRecebimento", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tab_fornecedores", "QuantidadeRecebimento");
        }
    }
}
