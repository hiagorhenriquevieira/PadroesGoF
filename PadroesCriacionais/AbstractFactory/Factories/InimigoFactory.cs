using PadroesGoF.PadroesCriacionais.AbstractFactory.Entidades;
using PadroesGoF.PadroesCriacionais.AbstractFactory.Interfaces;

namespace PadroesGoF.PadroesCriacionais.AbstractFactory.Factories
{
    public static class InimigoFactory
    {
        //Ambos os metodos retornam a interface, porem é instanciado a classe concreta diferente entre elas
        public static IInimigo ObterAtirador()
            => new Atirador();

        public static IInimigo ObterGuerreiro()
            => new Guerreiro();
    }
}
