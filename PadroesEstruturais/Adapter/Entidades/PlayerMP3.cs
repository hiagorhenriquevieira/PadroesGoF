using System;

namespace PadroesGoF.PadroesEstruturais.Adapter.Entidades
{
    public class PlayerMP3
    {
        public void PlayMP3(string arquivo)
        {
            Console.WriteLine($"Reproduzindo arquivo MP3: {arquivo}");
        }
    }
}
