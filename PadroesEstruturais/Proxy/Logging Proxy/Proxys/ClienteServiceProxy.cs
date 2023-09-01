using PadroesGoF.PadroesEstruturais.Logging_Proxy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesGoF.PadroesEstruturais.Logging_Proxy.Proxys
{
    public class ClienteServiceProxy
    {
        private ClienteService _service { get; set; }

        public ClienteServiceProxy()
        {
            _service = new ClienteService();
        }

        public object ObterCliente(int id)
        {
            var result = _service.ObterCliente(id);
            //Apos usar o servico ele gera o log
            GerarLog(id);

            return result;
        }

        private void GerarLog(int id)
        {
            Console.WriteLine($"Gerando log do cliente: {id}");
        }
    }
}
