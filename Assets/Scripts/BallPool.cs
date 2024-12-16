using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BallPool : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform parentTransform;
    [SerializeField] private int initialPoolSize = 10;

    private readonly Queue<GameObject> ballPool = new Queue<GameObject>();

    private void Start()
    {
        for (int i = 0; i < initialPoolSize; i++)
        {
            CreateAndAddBallToPool();
        }
    }

    public GameObject GetBall()
    {
        if (ballPool.Count > 0)
        {
            var ball = ballPool.Dequeue();
            ball.SetActive(true);
            return ball;
        }

        Debug.LogWarning("Pool is empty, instantiating new ball.");
        return CreateAndAddBallToPool(active: true);
    }

    public void ReturnBall(GameObject ball)
    {
        ball.SetActive(false);
        ball.transform.SetParent(parentTransform);
        ballPool.Enqueue(ball);
    }

    private GameObject CreateAndAddBallToPool(bool active = false)
    {
        var ball = Instantiate(ballPrefab, parentTransform);
        ball.SetActive(active);
        if (!active)
        {
            ballPool.Enqueue(ball);
        }
        return ball;
    }
}
