using PadroesGoF.PadroesEstruturais.Adapter.Entidades;
using PadroesGoF.PadroesEstruturais.Adapter.Interfaces;

namespace PadroesGoF.PadroesEstruturais.Adapter.Adapter
{
    public class AdaptadorMP3 : IPlayer
    {
        private PlayerMP3 player;

        public AdaptadorMP3(PlayerMP3 player)
        {
            this.player = player;
        }

        public void Play(string arquivo)
        {
            player.PlayMP3(arquivo);
        }
    }
}
