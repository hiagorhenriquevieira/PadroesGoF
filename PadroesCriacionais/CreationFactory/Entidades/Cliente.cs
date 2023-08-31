namespace PadroesGoF.PadroesCriacionais.CreationFactory.Entidades
{
    public class Cliente
    {
        //Essa classe possui dois contrutores para duas ocasioes, uma para ver o endereço do cliente e outra para venda a prazo
        public Cliente(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public Cliente(string nome, decimal limiteDeVendaAPrazo)
        {
            Nome = nome;
            LimiteDeVendaAPrazo = limiteDeVendaAPrazo;
        }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public decimal LimiteDeVendaAPrazo { get; set; }
    }
}