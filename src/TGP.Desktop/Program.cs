using osu.Framework.Platform;
using osu.Framework;
using TGP.Game;

namespace TGP.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"TGP"))
            using (osu.Framework.Game game = new TGPGame())
                host.Run(game);
        }
    }
}
