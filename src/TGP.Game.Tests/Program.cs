using osu.Framework;
using osu.Framework.Platform;

namespace TGP.Game.Tests
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost("visual-tests"))
            using (var game = new TGPTestBrowser())
                host.Run(game);
        }
    }
}
