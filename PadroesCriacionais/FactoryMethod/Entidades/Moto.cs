using System;

namespace PadroesGoF.PadroesCriacionais.FactoryMethod.Entidades
{
    //Classe para representar uma moto
    public class Moto : Veiculo
    {
        public override void Fabricar()
        {
            //Aqui é feita toda a construção da moto.
            Console.WriteLine("Moto fabricada.");
        }
    }
}