using ProdutosV1;
using EstoqueEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Data.Entity;

namespace ProdutosV1
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service" no arquivo de código, svc e configuração ao mesmo tempo.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicoEstoqueV1 : IServicoEstoqueV1
    {

        public List<string> ListarProdutos()
        {
            // Create a list of products            
            List<string> listaProdutos = new List<string>();
            try
            {
                // Connect to the ProductsModel database                  
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Fetch the products in the database 
                    List<ProdutoEstoque> produtoestoques = (from produtoestoque in database.ProdutoEstoques select produtoestoque).ToList();
                    foreach (ProdutoEstoque produtoestoque in produtoestoques)
                    {
                        
                        listaProdutos.Add(produtoestoque.NumeroProduto);
                    }
                }
            }
            catch
            {
                // Ignore exceptions in this implementation             
            }
            // Return the list of products             
            return listaProdutos;
        }

        public bool IncluirProduto(ProdutoTO ProdutoTO)
        {
            try
            {
                // Connect to the ProductsModel database                  
                using (ProvedorEstoque database = new ProvedorEstoque())
                {

                    ProdutoEstoque produtoestoque = new ProdutoEstoque();
                    produtoestoque.NumeroProduto = ProdutoTO.getNumeroProduto();
                    produtoestoque.NomeProduto = ProdutoTO.getNomeProduto();
                    produtoestoque.DescricaoProduto = ProdutoTO.getDescricaoProduto();
                    produtoestoque.EstoqueProduto = ProdutoTO.getEstoqueProduto();
                    database.ProdutoEstoques.Add(produtoestoque);
                    // Save the change back to the database                    
                    database.SaveChanges();
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure                    
                return false;
            }

            // Return true to indicate success              
            return true;
        }

        public bool RemoverProduto(string NumeroProduto)
        {
            try
            {
                // Connect to the ProductsModel database                  
                using (ProvedorEstoque database = new ProvedorEstoque())
                {

                    ProdutoEstoque produtoEstoqueDB = database.ProdutoEstoques.First(pe => pe.NumeroProduto == NumeroProduto);
                    if (produtoEstoqueDB == null)
                        return false;

                    database.ProdutoEstoques.Remove(produtoEstoqueDB);
                    // Save the change back to the database                    
                    database.SaveChanges();
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure                    
                return false;
            }

            // Return true to indicate success              
            return true;
        }

        public int ConsultarEstoque(string NumeroProduto)
        {
            int quantidadeTotal = 0;
            try
            {
                // Connect to the ProductsModel database                  
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    
                    ProdutoEstoque produtoEstoqueDB = database.ProdutoEstoques.Find(NumeroProduto);
                    if (produtoEstoqueDB != null)
                    {

                        quantidadeTotal = produtoEstoqueDB.EstoqueProduto;
                    }
                   
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure                    
            }

            // Return true to indicate success              
            return quantidadeTotal;
        }

        public bool AdcionarEstoque(string NumeroProduto, int Quantidade)
        {
            try
            {
                // Connect to the ProductsModel database                  
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    
                    ProdutoEstoque produtoEstoqueDB = database.ProdutoEstoques.Find(NumeroProduto);
                    if (produtoEstoqueDB != null)
                    {

                        database.Entry(produtoEstoqueDB).State = EntityState.Modified;

                        int quantidadeTotal = produtoEstoqueDB.EstoqueProduto;
                        quantidadeTotal += Quantidade;
                        produtoEstoqueDB.EstoqueProduto = quantidadeTotal;

                        // Save the change back to the database                    
                        database.SaveChanges();
                    }
                    else
                        return false;
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure                    
                return false;
            }

            // Return true to indicate success              
            return true;
        }

        public bool RemoverEstoque(string NumeroProduto, int Quantidade)
        {
            try
            {
                // Connect to the ProductsModel database                  
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    
                    ProdutoEstoque produtoEstoqueDB = database.ProdutoEstoques.Find(NumeroProduto);
                    if (produtoEstoqueDB != null)
                    {
                        database.Entry(produtoEstoqueDB).State = EntityState.Modified;
                        
                        int quantidadeTotal = produtoEstoqueDB.EstoqueProduto;
                        
                        quantidadeTotal -= Quantidade;
                        
                        produtoEstoqueDB.EstoqueProduto = quantidadeTotal;

                        // Save the change back to the database                    
                        database.SaveChanges();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure                    
                return false;
            }

            // Return true to indicate success              
            return true;
        }

        public ProdutoTO VerProduto(string NumeroProduto)
        {
            ProdutoTO produtoTO = null;
            try
            {
                // Connect to the ProductsModel database                  
                using (ProvedorEstoque database = new ProvedorEstoque())
                {

                    ProdutoEstoque produtoEstoqueDB = database.ProdutoEstoques.First(pe => pe.NumeroProduto == NumeroProduto);
                    if (produtoEstoqueDB != null) {
                        produtoTO = new ProdutoTO();
                        produtoTO.setNumeroProduto(produtoEstoqueDB.NumeroProduto);
                        produtoTO.setNomeProduto(produtoEstoqueDB.NomeProduto);
                        produtoTO.setDescricaoProduto(produtoEstoqueDB.DescricaoProduto);
                        produtoTO.setEstoqueProduto(produtoEstoqueDB.EstoqueProduto);
                    }
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure                    
            }

            // Return true to indicate success              
            return produtoTO;
        }

    }
}
