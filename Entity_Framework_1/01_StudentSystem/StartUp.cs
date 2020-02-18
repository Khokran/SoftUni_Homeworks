using _01_StudentSystem.Data;

namespace _01_StudentSystem
{
    public class StartUp
    {
        private static void Main()
        {
            var db = new StudentSystemContext();

            db.Database.EnsureCreated();
        }
    }
}