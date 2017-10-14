namespace EstoqueEntityModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class ProvedorEstoque : DbContext
    {
        // Your context has been configured to use a 'ProvedorEstoque' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EstoqueEntityModel.ProvedorEstoque' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ProvedorEstoque' 
        // connection string in the application configuration file.
        public ProvedorEstoque()
            : base("name=ProvedorEstoque")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<ProdutoEstoque> ProdutoEstoques { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    
    public class ProdutoEstoque
    {
        /*
            Nome do Campo                 |  Tipo         | Permite Nulos?
            NumeroProduto(chave primária) |  nchar(10)    |  Não 
            NomeProduto                   |  nchar(20)    |  Sim 
            DescricaoProduto              |  nchar(50)    |  Sim 
            EstoqueProduto                |  Int          |  Sim
        */

        [Key]
        [Required]
        [StringLength(10, ErrorMessage = "O tamanho máximo do Numero Produto é 10 caracteres")]
        public string NumeroProduto { get; set; }

        [StringLength(20, ErrorMessage = "O tamanho máximo do Nome Produto é 20 caracteres")]
        public string NomeProduto { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho máximo do Descricao Produto é 50 caracteres")]
        public string DescricaoProduto { get; set; }

        public int EstoqueProduto { get; set; }
    }

}