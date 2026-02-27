using PlayerDI;
using UnityEngine;
using Zenject;

public class MainInstaller : MonoInstaller
{
    [SerializeField] private int startHealth = 100;
    [SerializeField] private int startLives = 3;
    [SerializeField] private int rifleAmmo = 50;
    [SerializeField] private int rocketCharges = 3;

    public override void InstallBindings()
    {
        Container.Bind<IEquipment>().To<Equipment>().AsSingle();

        Container.Bind<IPlayer>().To<Player>().AsSingle()
            .WithArguments(startHealth, startLives);

        Container.Bind<Weapon>().AsTransient().WithArguments(rifleAmmo);

        Container.Bind<RocketPack>().AsTransient().WithArguments(rocketCharges);

        Container.Bind<Parachute>().AsTransient();
    }
}