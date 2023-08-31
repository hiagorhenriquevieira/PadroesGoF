using PadroesGoF.PadroesEstruturais.Proxy.Entidades;

namespace PadroesGoF.PadroesEstruturais.Proxy.Interfaces
{
    public interface IPessoa
    {
        Endereco ObterEndereco();
        void AtribuirEndereco(Endereco endereco);


    }
}