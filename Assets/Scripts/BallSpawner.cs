using UnityEngine;
using Zenject;

public class BallSpawner : MonoBehaviour
{
   [SerializeField] private BallPool ballPool;
    [SerializeField] private Transform root;
    //[Inject]
    //private void Construct(BallPool ballPool)
    //{
    //    this.ballPool = ballPool;
    //}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var ball = ballPool.GetBall();
            ball.transform.position = root.position; // Наприклад, розміщуємо в центрі
        }
    }
}
