using PadroesGoF.PadroesCriacionais.FactoryMethod.Entidades;
using PadroesGoF.PadroesCriacionais.FactoryMethod.Interface;

namespace PadroesGoF.PadroesCriacionais.FactoryMethod.Factories
{
    public class MotoFactory : IVeiculosFactory
    {
        public Veiculo CriarVeiculo()
        {
            return new Moto();
        }
    }
}
