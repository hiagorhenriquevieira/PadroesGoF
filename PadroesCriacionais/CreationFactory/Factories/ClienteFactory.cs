using PadroesGoF.PadroesCriacionais.CreationFactory.Entidades;

namespace PadroesGoF.PadroesCriacionais.CreationFactory.Factories
{
    public class ClienteFactory
    {
        //com as factories, fica mais claro qual construtor usar na ocasião certa
        public static Cliente ObterClienteComEndereco(string nome, string endereco)
            => new Cliente(nome, endereco);

        public static Cliente ObterClienteParaVendaAPrazo(string nome, decimal limite)
            => new Cliente(nome, limite);
    }
}
