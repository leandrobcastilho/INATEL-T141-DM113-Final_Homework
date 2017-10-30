using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ClienteProvedorEstoqueV2.ServicoEstoque;

namespace ClienteProvedorEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press ENTER when the service 2 has started");
            Console.ReadLine();

            //ServicoEstoqueClient proxy = new ServicoEstoqueClient();
            //ServicoEstoqueV2Client proxy = new ServicoEstoqueV2Client("BasicHttpBinding_IServicoEstoque");
            ServicoEstoqueV2Client proxy = new ServicoEstoqueV2Client("WS2007HttpBinding_IProductsService");

            Console.WriteLine("---ServicoEstoqueV2-----------------------------------------");

            string NumeroProduto = "1000";

            Console.WriteLine("Test 1: ConsultarEstoque( {0} )", NumeroProduto);
            int qtd1 = proxy.ConsultarEstoque(NumeroProduto);
            Console.WriteLine("return: {0}", qtd1);
            Console.WriteLine();

            int EstoqueProduto = 2;
            Console.WriteLine("Test 2: AdcionarEstoque( {0}, {1} )", NumeroProduto, EstoqueProduto);
            bool c = proxy.AdcionarEstoque(NumeroProduto, EstoqueProduto);
            Console.WriteLine("return: {0}", c);
            Console.WriteLine();

            Console.WriteLine("Test 3: ConsultarEstoque( {0} )", NumeroProduto);
            int qtd2 = proxy.ConsultarEstoque(NumeroProduto);
            Console.WriteLine("return: {0}", qtd2);
            Console.WriteLine();

            int EstoqueProduto1 = 2;
            Console.WriteLine("Test 4: RemoverEstoque( {0}, {1} )", NumeroProduto, EstoqueProduto);
            bool d = proxy.RemoverEstoque(NumeroProduto, EstoqueProduto1);
            Console.WriteLine("return: {0}", d);
            Console.WriteLine();

            Console.WriteLine("Test 5: ConsultarEstoque( {0} )", NumeroProduto);
            int qtd3 = proxy.ConsultarEstoque(NumeroProduto);
            Console.WriteLine("return: {0}", qtd3);
            Console.WriteLine();

            // Disconnect from the service             
            proxy.Close();


            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();

        }

    }
}
