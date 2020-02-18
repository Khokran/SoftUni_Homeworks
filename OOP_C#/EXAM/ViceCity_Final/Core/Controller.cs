namespace ViceCity.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Contracts;
    using Factories.Contracts;
    using Models.Guns.Contracts;
    using Models.Neghbourhoods.Contracts;
    using Models.Players;
    using Models.Players.Contracts;

    public class Controller : IController
    {
        private const string MainPlayerName = "Vercetti";

        private readonly List<IPlayer> civilPlayers;
        private readonly Queue<IGun> guns;

        private readonly MainPlayer mainPlayer;
        private readonly INeighbourhood neighbourhood;

        private readonly IGunFactory gunFactory;
        private readonly ICivilPlayerFactory civilPlayerFactory;

        public Controller(
            MainPlayer mainPlayer,
            INeighbourhood neighbourhood,
            IGunFactory gunFactory,
            ICivilPlayerFactory civilPlayerFactory)
        {
            this.mainPlayer = mainPlayer;
            this.neighbourhood = neighbourhood;
            this.gunFactory = gunFactory;
            this.civilPlayerFactory = civilPlayerFactory;

            this.civilPlayers = new List<IPlayer>();
            this.guns = new Queue<IGun>();
        }

        public string AddGun(string type, string name)
        {
            var gun = this.gunFactory.CreateGun(type, name);

            this.guns.Enqueue(gun);

            return $"Successfully added {name} of type: {gun.GetType().Name}";
        }

        public string AddGunToPlayer(string name)
        {
            if (this.guns.Count == 0)
            {
                return "There are no guns in the queue!";
            }

            var gun = this.guns.Peek();

            if (name == MainPlayerName)
            {
                this.mainPlayer.GunRepository.Add(this.guns.Dequeue());

                return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }

            if (!this.civilPlayers.Any(x => x.Name == name))
            {
                return "Civil player with that name doesn't exists!";
            }

            var player = this.civilPlayers.FirstOrDefault(x => x.Name == name);

            player.GunRepository.Add(this.guns.Dequeue());

            return $"Successfully added {gun.Name} to the Civil Player: {player.Name}";
        }

        public string AddPlayer(string name)
        {
            var player = this.civilPlayerFactory.CreateCivilPlayer(name);

            this.civilPlayers.Add(player);

            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            this.neighbourhood.Action(this.mainPlayer, this.civilPlayers);

            var areCivilsOk = this.civilPlayers
                .All(x => x.LifePoints == 50);

            var deadCivilPlayers = this.civilPlayers
                .Where(x => !x.IsAlive)
                .Count();

            if (this.mainPlayer.LifePoints == 100 && areCivilsOk)
            {
                return "Everything is okay!";
            }
            else
            {
                this.civilPlayers.RemoveAll(x => !x.IsAlive);

                var result = new StringBuilder();

                result.AppendLine("A fight happened:");
                result.AppendLine($"Tommy live points: {this.mainPlayer.LifePoints}!");
                result.AppendLine($"Tommy has killed: {deadCivilPlayers} players!");
                result.AppendLine($"Left Civil Players: {this.civilPlayers.Count}!");

                return result.ToString().TrimEnd();
            }
        }
    }
}
