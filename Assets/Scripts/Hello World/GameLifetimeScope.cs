using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace HelloWorld
{
    public class GameLifetimeScope : LifetimeScope
    {
        [SerializeField]
        HelloScreen helloScreen;
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<HelloWorldService>(Lifetime.Singleton);
            builder.RegisterEntryPoint<GamePresenter>(Lifetime.Singleton);
            builder.RegisterComponent(helloScreen);
        }
    }
}
