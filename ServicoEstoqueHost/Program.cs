using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ProdutosV1;
//using ProdutosV2;

namespace ServicoEstoqueHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost servicoEstoqueV1Host = new ServiceHost(typeof(ServicoEstoqueV1));
            servicoEstoqueV1Host.Open();
            Console.WriteLine("Service 1 Running");
            //ServiceHost servicoEstoqueV2Host = new ServiceHost(typeof(ServicoEstoqueV2));
            //servicoEstoqueV2Host.Open();
            //Console.WriteLine("Service 2 Running");

            Console.ReadLine();
            Console.WriteLine("Service 1 Stopping");
            servicoEstoqueV1Host.Close();
            //Console.WriteLine("Service 2 Stopping");
            //servicoEstoqueV2Host.Close();
        }
    }
}
