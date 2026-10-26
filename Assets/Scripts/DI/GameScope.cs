using Lab.Controls;
using Lab.Flame;
using Lab.Managers;
using Lab.Managers.Spawn;
using Lab.Player.Death;
using Lab.Player.Triggers;
using Lab.Pooling;
using Lab.Score;
using Lab.Slide;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Lab.DI
{
    public class GameScope : LifetimeScope
    {
        [SerializeField] private PoolData[] _poolDatas;
        [SerializeField] private Transform _playerTransform;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(_poolDatas);
            builder.RegisterInstance(_playerTransform);

            //Pooling
            builder.RegisterEntryPoint<PoolService>().AsSelf();

            //Input
            builder.Register<InputManager>(Lifetime.Singleton);

            //Controls
            builder.RegisterComponentInHierarchy<FlyControls>();

            //Flame
            builder.RegisterComponentInHierarchy<FlameToggle>();

            //Spawn
            builder.Register<SpawnContext>(Lifetime.Singleton);
            builder.RegisterComponentInHierarchy<SpawnManager>();

            //Death
            builder.RegisterComponentInHierarchy<PlayerDeathHandler>();
            builder.RegisterComponentInHierarchy<LaserTrigger>();

            //Score
            builder.Register<ScoreCounter>(Lifetime.Singleton);
            builder.RegisterComponentInHierarchy<ScoreHUD>();
            builder.RegisterComponentInHierarchy<CoinTrigger>();

            //Slide
            builder.RegisterComponentInHierarchy<SlideRightwards>();
        }
    }
}