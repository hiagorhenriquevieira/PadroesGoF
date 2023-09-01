using PadroesGoF.PadroesEstruturais.Adapter.Interfaces;
using System;

namespace PadroesGoF.PadroesEstruturais.Adapter.Entidades
{
    public class ClasseNova : IInterfaceNova
    {
        public void MetodoNovo()
        {
            Console.WriteLine("Metodo novo da classe nova.");
        }
    }
}
