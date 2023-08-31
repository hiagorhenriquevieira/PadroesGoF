using PadroesGoF.PadroesEstruturais.Adapter.Entidades;
using PadroesGoF.PadroesEstruturais.Adapter.Interfaces;

namespace PadroesGoF.PadroesEstruturais.Adapter.Adapter
{
    public class AdaptadorWMA : IPlayer
    {
        private PlayerWMA player;

        public AdaptadorWMA(PlayerWMA player)
        {
            this.player = player;
        }

        public void Play(string arquivo)
        {
            player.PlayWMA(arquivo);
        }
    }
}
