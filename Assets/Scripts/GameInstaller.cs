using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private PlinkoGridGenerator gridGenerator;

    public override void InstallBindings()
    {
        Container.Bind<PlinkoGridGenerator>().FromInstance(gridGenerator).AsSingle().Lazy();
    }
}
