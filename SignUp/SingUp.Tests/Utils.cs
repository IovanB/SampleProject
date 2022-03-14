using SignUp.Infrastructure;

namespace SingUp.Tests
{
    public static class Utils
    {
        public static void CleanDatabase()
        {
            var context = new Context();
            context.Database.EnsureDeleted();
        }
    }
}
