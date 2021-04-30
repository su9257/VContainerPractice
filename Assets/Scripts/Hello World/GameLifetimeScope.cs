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
            builder.Register<HelloWorldService>(Lifetime.Singleton);//某一个功能
            builder.RegisterComponent(helloScreen);
            //builder.Register<GamePresenter>(Lifetime.Singleton).As<ITickable>().As<IStartable>();
            builder.RegisterEntryPoint<GamePresenter>(Lifetime.Singleton);
        }
    }

    class Foo
    {
        
    }
}
