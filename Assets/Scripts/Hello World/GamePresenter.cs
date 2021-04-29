using VContainer;
using VContainer.Unity;

namespace HelloWorld
{
    public class GamePresenter : ITickable, IStartable
    {
        readonly HelloWorldService helloWorldService;
        readonly HelloScreen helloScreen;

        [Inject]
        public GamePresenter(HelloWorldService helloWorldService, HelloScreen helloScreen)
        {
            this.helloWorldService = helloWorldService;
            this.helloScreen = helloScreen;
            UnityEngine.Debug.Log(new string('*', 20));
        }

        void IStartable.Start()
        {
            helloScreen.HelloButton.onClick.AddListener(() => helloWorldService.Hello());
        }

        void ITickable.Tick()
        {
            //UnityEngine.Debug.Log("Update");
            //helloWorldService.Hello();
        }
    }
}
