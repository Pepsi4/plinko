using UnityEngine;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<SceneLoader>().FromNew().AsSingle();
        //Container.Bind<Bootstrap>().FromComponentInHierarchy().AsSingle();
    }
}
