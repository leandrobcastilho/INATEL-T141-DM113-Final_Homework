﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Produtos
{

    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IServicoEstoque
    {
   
        [OperationContract]
        List<string> ListarProdutos();
        
        [OperationContract]
        bool IncluirProduto(ProdutoTO ProdutoTO);

        [OperationContract]
        bool RemoverProduto(string NumeroProduto);
     
        [OperationContract]
        int ConsultarEstoque(string NumeroProduto);

        [OperationContract]
        bool AdcionarEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        ProdutoTO VerProduto(string NumeroProduto);

    }

    [DataContract]
    public class ProdutoTO
    {

        [DataMember]
        private string NumeroProduto;

        [DataMember]
        private string NomeProduto;

        [DataMember]
        private string DescricaoProduto;

        [DataMember]
        private int EstoqueProduto;

        public string getNumeroProduto()
        {
              return this.NumeroProduto;
        }

        public void setNumeroProduto(string NumeroProduto)
        {
            this.NumeroProduto = NumeroProduto;
        }

        public string getNomeProduto()
        {
            return this.NomeProduto;
        }

        public void setNomeProduto(string NomeProduto)
        {
            this.NomeProduto = NomeProduto;
        }

        public string getDescricaoProduto()
        {
            return this.DescricaoProduto;
        }

        public void setDescricaoProduto(string DescricaoProduto)
        {
            this.DescricaoProduto = DescricaoProduto;
        }

        public int getEstoqueProduto()
        {
            return this.EstoqueProduto;
        }

        public void setEstoqueProduto(int EstoqueProduto)
        {
            this.EstoqueProduto = EstoqueProduto;
        }

    }
}
