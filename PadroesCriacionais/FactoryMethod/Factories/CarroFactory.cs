using PadroesGoF.PadroesCriacionais.FactoryMethod.Entidades;
using PadroesGoF.PadroesCriacionais.FactoryMethod.Interface;

namespace PadroesGoF.PadroesCriacionais.FactoryMethod.Factories
{
    public class CarroFactory : IVeiculosFactory
    {
        public Veiculo CriarVeiculo()
        {
            return new Carro();
        }
    }
}
