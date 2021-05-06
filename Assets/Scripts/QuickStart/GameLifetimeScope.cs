using VContainer;
using VContainer.Unity;

namespace QuickStart
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<ActorPresenter>().As<IStartable>();

            builder.Register<CharacterService>(Lifetime.Scoped);
            builder.Register<IRouteSearch, AStarRouteSearch>(Lifetime.Singleton);

            builder.RegisterComponentInHierarchy<ActorsView>();
        }
    }


    public class CharacterService
    {
        readonly IRouteSearch routeSearch;

        public CharacterService(IRouteSearch routeSearch)
        {
            this.routeSearch = routeSearch;
        }
    }

    public class ActorPresenter : IStartable
    {
        readonly CharacterService service;
        readonly ActorsView actorsView;

        public ActorPresenter(CharacterService service, ActorsView actorsView)
        {
            this.service = service;
            this.actorsView = actorsView;
        }

        void IStartable.Start()
        {
            // Scheduled at Start () on VContainer's own PlayerLoopSystem.
            actorsView.Print();
        }
    }
}
