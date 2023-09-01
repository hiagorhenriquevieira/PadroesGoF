using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class EnderecoServiceProxy
{
	private List<EnderecoResult> _enderecos { get; set; }
	private EnderecoService _service { get; set; }

	public EnderecoServiceProxy()
	{
		_enderecos = new List<EnderecoResult>();
		_service = new EnderecoService();
	}

	public EnderecoResult ObterEnderecoAtravesDoCep(string cep)
    {
		//Verifica se o cep já foi buscado antes
		if (_enderecos.Any((x) => x.Cep == cep))
			return _enderecos.First((x) => x.Cep == cep);

		//Caso não tenha no cache, ele busca pelo service e adiciona no cache
		var result = _service.ObterEnderecoAtravesDoCep(cep);
		_enderecos.Add(result);
		return result;
    }
}
