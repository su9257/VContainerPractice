using VContainer;
using VContainer.Unity;

namespace Resolving
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<IServiceA, ServiceA>(Lifetime.Singleton).WithParameter("A");
            builder.Register<IServiceA, ServiceAExtension>(Lifetime.Singleton).WithParameter("AExtension");
            builder.Register<IServiceB, ServiceB>(Lifetime.Singleton).WithParameter("B");
            builder.Register<ServiceC>(Lifetime.Singleton);
            builder.RegisterComponentOnNewGameObject<SomeUnityComponent>(Lifetime.Singleton);
            builder.RegisterEntryPoint<ClassA>(Lifetime.Singleton);
        }
    }
}
