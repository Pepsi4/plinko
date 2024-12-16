using UnityEngine;
using Zenject;

public class PlinkoGridGenerator : MonoBehaviour
{
    [SerializeField] private GameObject pegPrefab;
    [SerializeField] private Transform gridParent;
    [SerializeField] private int rows = 14;
    [SerializeField] private float xSpacing = 0.5f;
    [SerializeField] private float ySpacing = 0.5f;
    [SerializeField] private int startFromRow = 2;

    private void Start()
    {
        GenerateGrid();
    }

    public void GenerateGrid()
    {
        for (int row = startFromRow; row < rows; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                float xPos = col * xSpacing - (row * xSpacing / 2);
                float yPos = -row * ySpacing;

                GameObject peg = Instantiate(pegPrefab, gridParent);
                peg.transform.localPosition = new Vector3(xPos, yPos, 0);
            }
        }
    }
}
