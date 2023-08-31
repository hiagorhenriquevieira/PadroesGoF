using System;

namespace PadroesGoF.PadroesCriacionais.FactoryMethod.Entidades
{
    // Classe para representar um carro
    public class Carro : Veiculo
    {
        public override void Fabricar()
        {
            //Aqui é onde é feita toda a construção do veiculo carro.
            Console.WriteLine("Carro fabricado.");
        }
    }
}