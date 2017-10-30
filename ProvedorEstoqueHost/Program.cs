using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using EstoqueLibrary;

namespace ProvedorEstoqueHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost servicoEstoqueV1Host = new ServiceHost(typeof(ServicoEstoque));
            servicoEstoqueV1Host.Open();
            Console.WriteLine("Service Running");

            Console.WriteLine("Press ENTER to stop services");
            Console.ReadLine();
            Console.WriteLine("Service Stopping");
            servicoEstoqueV1Host.Close();
        }
    }
}
