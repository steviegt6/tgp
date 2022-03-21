using osu.Framework.Testing;

namespace TGP.Game.Tests.Visual
{
    public class TGPTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new TGPTestSceneTestRunner();

        private class TGPTestSceneTestRunner : TGPGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
