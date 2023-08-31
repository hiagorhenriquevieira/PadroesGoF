using System;

namespace PadroesGoF.PadroesEstruturais.Adapter.Entidades
{
    public class PlayerWMA
    {
        public void PlayWMA(string arquivo)
        {
            Console.WriteLine($"Reproduzindo arquivo WMA: {arquivo}");
        }
    }
}
