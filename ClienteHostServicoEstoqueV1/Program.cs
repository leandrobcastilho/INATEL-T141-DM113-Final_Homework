using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ClienteHostServicoEstoqueV1.ServicoEstoqueV1;

namespace ClienteHostServicoEstoqueV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service 1 has started");
            Console.ReadLine();

            //ServicoEstoqueV1Client proxyV1 = new ServicoEstoqueV1Client();
            ServicoEstoqueV1Client proxyV1 = new ServicoEstoqueV1Client("NetTcpBinding_IServicoEstoqueV1");

            Console.WriteLine("---ServicoEstoqueV1-----------------------------------------");

            Console.WriteLine("Test 0: ListarProdutos( )");
            List<string> listaProduto = proxyV1.ListarProdutos().ToList();
            Console.WriteLine("listaProduto: {0}", listaProduto.Count);
            Console.WriteLine();
            foreach (string numeroProduto in listaProduto)
            {
                Console.WriteLine("NumeroProduto: {0}", numeroProduto);
            }
            Console.WriteLine();

            string NumeroProduto1 = "1000";
            Console.WriteLine("Test 1: VerProduto( {0} )", NumeroProduto1);
            ProdutoTO produtoTO3 = proxyV1.VerProduto(NumeroProduto1);
            Console.WriteLine("produtoTO: {0}", produtoTO3);
            if (produtoTO3 != null)
            {
                Console.WriteLine("NumeroProduto: {0}", produtoTO3.NumeroProduto);
                Console.WriteLine("NomeProduto: {0}", produtoTO3.NomeProduto);
                Console.WriteLine("DescricaoProduto: {0}", produtoTO3.DescricaoProduto);
                Console.WriteLine("EstoqueProduto: {0}", produtoTO3.EstoqueProduto);
            }
            Console.WriteLine();

            Console.WriteLine("Test 2: ListarProdutos( VerProduto() )");
            List<string> listaProduto0 = proxyV1.ListarProdutos().ToList();
            Console.WriteLine("listaProduto: {0}", listaProduto0.Count);
            Console.WriteLine();
            foreach (string numeroProduto in listaProduto0)
            {
                ProdutoTO produtoTO = proxyV1.VerProduto(numeroProduto);
                if (produtoTO != null)
                {
                    Console.WriteLine("Produto: {0} - {1} - {2} - {3}", produtoTO.NumeroProduto, produtoTO.NomeProduto, produtoTO.DescricaoProduto, produtoTO.EstoqueProduto);
                }
            }
            Console.WriteLine();


            Console.WriteLine("Test 3: ConsultarEstoque( {0} )", NumeroProduto1);
            int qtd1 = proxyV1.ConsultarEstoque(NumeroProduto1);
            Console.WriteLine("return: {0}", qtd1);
            Console.WriteLine();

            string NumeroProduto = "10000";
            Console.WriteLine("Test 4: RemoverProduto( {0} )", NumeroProduto);
            bool a = proxyV1.RemoverProduto(NumeroProduto);
            Console.WriteLine("return: {0}", a);
            Console.WriteLine();

            Console.WriteLine("Test 5: ListarProdutos( )");
            List<string> listaProduto1 = proxyV1.ListarProdutos().ToList();
            Console.WriteLine("listaProduto: {0}", listaProduto1.Count);
            Console.WriteLine();
            foreach (string numeroProduto in listaProduto1)
            {
                Console.WriteLine("NumeroProduto: {0}", numeroProduto);
            }
            Console.WriteLine();

            ProdutoTO produto = new ProdutoTO();
            produto.NumeroProduto = "10000";
            produto.NomeProduto = "Produto 10";
            produto.DescricaoProduto = "Este é o produto 10";
            produto.EstoqueProduto = 20;
            Console.WriteLine("Test 6: IncluirProduto(Produto: {0} - {1} - {2} - {3})", produto.NumeroProduto, produto.NomeProduto, produto.DescricaoProduto, produto.EstoqueProduto);
            bool b = proxyV1.IncluirProduto(produto);
            Console.WriteLine("return: {0}", b);
            Console.WriteLine();

            Console.WriteLine("Test 7: ListarProdutos( )");
            List<string> listaProduto2 = proxyV1.ListarProdutos().ToList();
            Console.WriteLine("listaProduto: {0}", listaProduto2.Count);
            Console.WriteLine();
            foreach (string numeroProduto in listaProduto2)
            {
                Console.WriteLine("NumeroProduto: {0}", numeroProduto);
            }
            Console.WriteLine();

            int EstoqueProduto = 2;
            Console.WriteLine("Test 8: AdcionarEstoque( {0}, {1} )", NumeroProduto, EstoqueProduto);
            bool c = proxyV1.AdcionarEstoque(NumeroProduto, EstoqueProduto);
            Console.WriteLine("return: {0}", c);
            Console.WriteLine();

            Console.WriteLine("Test 9: VerProduto( {0} )", NumeroProduto);
            ProdutoTO produtoTO1 = proxyV1.VerProduto(NumeroProduto);
            Console.WriteLine("produtoTO: {0}", produtoTO1);
            if (produtoTO1 != null)
            {
                Console.WriteLine("Produto: {0} - {1} - {2} - {3}", produtoTO1.NumeroProduto, produtoTO1.NomeProduto, produtoTO1.DescricaoProduto, produtoTO1.EstoqueProduto);
            }
            Console.WriteLine();

            int EstoqueProduto1 = 2;
            Console.WriteLine("Test 10: RemoverEstoque( {0}, {1} )", NumeroProduto, EstoqueProduto);
            bool d = proxyV1.RemoverEstoque(NumeroProduto, EstoqueProduto1);
            Console.WriteLine("return: {0}", d);
            Console.WriteLine();

            Console.WriteLine("Test 11: VerProduto( {0} )", NumeroProduto);
            ProdutoTO produtoTO2 = proxyV1.VerProduto(NumeroProduto);
            Console.WriteLine("produtoTO: {0}", produtoTO2);
            if (produtoTO2 != null)
            {
                Console.WriteLine("Produto: {0} - {1} - {2} - {3}", produtoTO2.NumeroProduto, produtoTO2.NomeProduto, produtoTO2.DescricaoProduto, produtoTO2.EstoqueProduto);
            }
            Console.WriteLine();

            // Disconnect from the service             
            proxyV1.Close();


            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();

        }

    }
}
