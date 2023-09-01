using PadroesGoF.PadroesEstruturais.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesGoF.PadroesEstruturais.Adapter.Adapter
{
    class Adaptador : IInterfaceNova
    {
        private readonly IInterfaceAntiga _classeAntiga;

        public Adaptador(IInterfaceAntiga classeAntiga)
        {
            _classeAntiga = classeAntiga;
        }

        public void MetodoNovo()
        {
            Console.WriteLine("Adaptador: Chamando o método antigo da classe dentro do novo método.");
            _classeAntiga.MetodoAntigo();
        }
    }
}
