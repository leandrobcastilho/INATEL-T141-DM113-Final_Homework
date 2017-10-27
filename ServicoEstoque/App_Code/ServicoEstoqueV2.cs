using ProdutosV2;
using EstoqueEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;

namespace ProdutosV2
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service" no arquivo de código, svc e configuração ao mesmo tempo.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicoEstoqueV2 : IServicoEstoqueV2
    {

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

    }
}
