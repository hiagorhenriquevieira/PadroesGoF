using PadroesGoF.PadroesEstruturais.Adapter.Interfaces;
using System;

namespace PadroesGoF.PadroesEstruturais.Adapter.Entidades
{
    public class ClasseAntiga : IInterfaceAntiga
    {
        public void MetodoAntigo()
        {
            Console.WriteLine("Metodo antigo da classe antiga.");
        }
    }
}
