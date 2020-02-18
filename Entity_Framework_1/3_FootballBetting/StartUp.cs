using _3_FootballBetting.Data;

namespace _3_FootballBetting
{
    public class StartUp
    {
        private static void Main()
        {
            var db = new FootballBettingContext();

            db.Database.EnsureCreated();
        }

    }
}
