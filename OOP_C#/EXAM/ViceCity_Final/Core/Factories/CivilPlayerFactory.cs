namespace ViceCity.Core.Factories
{
    using Contracts;
    using Models.Players;
    using Models.Players.Contracts;

    public class CivilPlayerFactory : ICivilPlayerFactory
    {
        public IPlayer CreateCivilPlayer(string name)
            => new CivilPlayer(name);
    }
}
