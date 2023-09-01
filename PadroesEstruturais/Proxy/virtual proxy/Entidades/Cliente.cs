using PadroesGoF.PadroesEstruturais.Proxy.Interfaces;

namespace PadroesGoF.PadroesEstruturais.Proxy.Entidades
{
    public class Cliente : IPessoa
    {
        private Endereco _endereco { get; set; }

        public void AtribuirEndereco(Endereco endereco)
        {
            _endereco = endereco;
        }

        public Endereco ObterEndereco()
        {
            return _endereco;
        }
    }
}
