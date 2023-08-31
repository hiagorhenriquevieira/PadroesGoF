using System;

public class EnderecoService
{
	public EnderecoService()
	{
	}

	public EnderecoResult ObterEnderecoAtravesDoCep(string cep)
    {
		return new EnderecoResult() { Cep = cep };
    }
}
