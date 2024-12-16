using UnityEngine;
using Zenject;

public class Bootstrap : MonoBehaviour
{
     private SceneLoader sceneLoader;
    [SerializeField] string playScene;

    [Inject]
    private void Construct(SceneLoader sceneLoader)
    {
        this.sceneLoader = sceneLoader;
    }

    private void Start()
    {
        sceneLoader.LoadScene(playScene);
    }
}
