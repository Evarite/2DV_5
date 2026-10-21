using Lab.Controls;
using Lab.Flame;
using Lab.Managers;
using VContainer;
using VContainer.Unity;

namespace Lab.DI
{
    public class GameScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            //Input
            builder.Register<InputManager>(Lifetime.Singleton);

            //Controls
            builder.RegisterComponentInHierarchy<FlyControls>();

            //Flame
            builder.RegisterComponentInHierarchy<FlameToggle>();
        }
    }
}