namespace ViceCity
{
    using Core;
    using Core.Factories;
    using IO;
    using Models.Neghbourhoods;
    using Models.Players;

    public class StartUp
    {
        public static void Main()
        {
            var consoleReader = new Reader();
            var consoleWriter = new Writer();

            var mainPlayer = new MainPlayer();
            var gangNeighbourhood = new GangNeighbourhood();
            var gunFactory = new GunFactory();
            var civilPlayerFactory = new CivilPlayerFactory();

            var controller = new Controller(
                mainPlayer,
                gangNeighbourhood,
                gunFactory,
                civilPlayerFactory);

            var engine = new Engine(
                consoleReader,
                consoleWriter,
                controller);

            engine.Run();
        }
    }
}
