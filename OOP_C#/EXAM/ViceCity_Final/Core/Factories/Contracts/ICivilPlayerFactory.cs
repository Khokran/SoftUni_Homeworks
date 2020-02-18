namespace ViceCity.Core.Factories.Contracts
{
    using Models.Players.Contracts;

    public interface ICivilPlayerFactory
    {
        IPlayer CreateCivilPlayer(string name);
    }
}
