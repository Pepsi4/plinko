using UnityEngine;
using Zenject;

public class PlinkoEntryPoint : MonoBehaviour
{
    [Inject] private PlinkoGridGenerator gridGenerator;

    private void Start()
    {
        if (gridGenerator == null)
        {
            Debug.LogError("GridGenerator is not injected! Check your Zenject bindings.");
            return;
        }

        gridGenerator.GenerateGrid();
    }
}
