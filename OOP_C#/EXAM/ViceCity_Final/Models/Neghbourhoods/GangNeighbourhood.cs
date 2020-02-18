namespace ViceCity.Models.Neghbourhoods
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Players.Contracts;

    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            while (true)
            {
                var gun = mainPlayer
                    .GunRepository
                    .Models
                    .FirstOrDefault(x => x.CanFire);

                if (gun == null)
                {
                    break;
                }

                var player = civilPlayers
                    .FirstOrDefault(x => x.IsAlive);

                if (player == null)
                {
                    break;
                }

                var damagePoints = gun.Fire();
                player.TakeLifePoints(damagePoints);
            }

            while (true)
            {
                var civilPlayer = civilPlayers
                    .FirstOrDefault(x => x.IsAlive);

                if (civilPlayer == null)
                {
                    break;
                }

                var civilPlayerGun = civilPlayer
                    .GunRepository
                    .Models
                    .FirstOrDefault(x => x.CanFire);

                if (civilPlayerGun == null)
                {
                    break;
                }

                var points = civilPlayerGun.Fire();
                mainPlayer.TakeLifePoints(points);

                if (!mainPlayer.IsAlive)
                {
                    break;
                }
            }
        }
    }
}
