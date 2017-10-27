using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProdutosV2
{

    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IServicoEstoqueV2
    {

        [OperationContract]
        int ConsultarEstoque(string NumeroProduto);

        [OperationContract]
        bool AdcionarEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);

    }

}
