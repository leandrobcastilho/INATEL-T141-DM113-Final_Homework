using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ClienteServicoEstoqueV2.ServicoEstoqueV2;

namespace ClienteServicoEstoqueV2
{
    class Program
    {
        static void Main(string[] args)
        {

            ServicoEstoqueV2Client proxyV2 = new ServicoEstoqueV2Client();

            Console.WriteLine("---ServicoEstoqueV2-----------------------------------------");

            string NumeroProduto = "1000";

            Console.WriteLine("Test 1: ConsultarEstoque( {0} )", NumeroProduto);
            int qtd1 = proxyV2.ConsultarEstoque(NumeroProduto);
            Console.WriteLine("return: {0}", qtd1);
            Console.WriteLine();

            int EstoqueProduto = 2;
            Console.WriteLine("Test 2: AdcionarEstoque( {0}, {1} )", NumeroProduto, EstoqueProduto);
            bool c = proxyV2.AdcionarEstoque(NumeroProduto, EstoqueProduto);
            Console.WriteLine("return: {0}", c);
            Console.WriteLine();

            Console.WriteLine("Test 3: ConsultarEstoque( {0} )", NumeroProduto);
            int qtd2 = proxyV2.ConsultarEstoque(NumeroProduto);
            Console.WriteLine("return: {0}", qtd2);
            Console.WriteLine();

            int EstoqueProduto1 = 2;
            Console.WriteLine("Test 4: RemoverEstoque( {0}, {1} )", NumeroProduto, EstoqueProduto);
            bool d = proxyV2.RemoverEstoque(NumeroProduto, EstoqueProduto1);
            Console.WriteLine("return: {0}", d);
            Console.WriteLine();

            Console.WriteLine("Test 5: ConsultarEstoque( {0} )", NumeroProduto);
            int qtd3 = proxyV2.ConsultarEstoque(NumeroProduto);
            Console.WriteLine("return: {0}", qtd3);
            Console.WriteLine();

            // Disconnect from the service             
            proxyV2.Close();


            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();

        }

    }
}
