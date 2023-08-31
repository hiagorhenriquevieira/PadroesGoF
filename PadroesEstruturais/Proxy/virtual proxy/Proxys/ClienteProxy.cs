using PadroesGoF.PadroesEstruturais.Proxy.Entidades;
using PadroesGoF.PadroesEstruturais.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesGoF.PadroesEstruturais.Proxy.Virtual_Proxy.Proxys
{
    public class ClienteProxy : IPessoa
    {
        private Cliente _cliente { get; set; }
        public ClienteProxy()
        {
            _cliente = new Cliente();
        }

        public Endereco ObterEndereco()
        {
            if (_cliente.ObterEndereco() == null)
                _cliente.AtribuirEndereco(new Endereco());

            return _cliente.ObterEndereco();
        }
    }
}
