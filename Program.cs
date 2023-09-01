using PadroesGoF.PadroesCriacionais.AbstractFactory.Factories;
using PadroesGoF.PadroesCriacionais.AbstractFactory.Interfaces;
using PadroesGoF.PadroesCriacionais.CreationFactory.Factories;
using PadroesGoF.PadroesCriacionais.FactoryMethod.Entidades;
using PadroesGoF.PadroesCriacionais.FactoryMethod.Factories;
using PadroesGoF.PadroesCriacionais.FactoryMethod.Interface;
using PadroesGoF.PadroesEstruturais.Adapter.Adapter;
using PadroesGoF.PadroesEstruturais.Adapter.Entidades;
using PadroesGoF.PadroesEstruturais.Adapter.Interfaces;
using System;

namespace PadroesGoF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Padrões de projeto Factory
            AplicarPadraoFactoryMethod();

            AplicaPadraoAbstractFactory();

            AplicarPadraoCreationFactory();

            //Padrão de projeto Adapter
            AplicarPadraoAdapter();


            //Padrão de projeto Proxy
            AplicarPadraoProxy();

        }

        private static void AplicarPadraoProxy()
        {

        }

        private static void AplicaPadraoAbstractFactory()
        {
            //Responsável por criar um inimigo do tipo atirador
            IInimigo atirador = InimigoFactory.ObterAtirador();

            //Responsável por criar um inimigo do tipo guerreiro
            IInimigo guerreiro = InimigoFactory.ObterGuerreiro();

        }

        private static void AplicarPadraoCreationFactory()
        {
            //Criando um cliente que tenha endereço
            var clienteComEndereco = ClienteFactory.ObterClienteComEndereco("Marco Aurelio", "Rua Dolores, São Paulo, nº 2001");

            //Criando um cliente que tenha limite de venda a prazo
            var clienteComLimiteDeCompraPrazo = ClienteFactory.ObterClienteParaVendaAPrazo("Epicteto", 30000m);
        }

        private static void AplicarPadraoFactoryMethod()
        {
            // Criando a fábrica de carros
            IVeiculosFactory carroFactory = new CarroFactory();
            Veiculo carro = carroFactory.CriarVeiculo();
            carro.Fabricar(); // Saída: Carro fabricado.

            // Criando a fábrica de Motos
            IVeiculosFactory motoFactory = new MotoFactory();
            Veiculo moto = motoFactory.CriarVeiculo();
            moto.Fabricar(); // Saída: Moto fabricada.
        }

        private static void AplicarPadraoAdapter()
        {
            // Usando a classe nova diretamente
            IInterfaceNova classeNova = new ClasseNova();
            classeNova.MetodoNovo();

            Console.WriteLine();

            // Usando o adaptador para utilizar a classe antiga através da interface nova
            IInterfaceAntiga classeAntiga = new ClasseAntiga();
            Adaptador adaptador = new Adaptador(classeAntiga);
            adaptador.MetodoNovo();
        }
    }
}