using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class BallPool : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform parentTransform;
    private readonly Queue<GameObject> ballPool = new Queue<GameObject>();

    public GameObject GetBall()
    {
        if (ballPool.Count > 0)
        {
            var ball = ballPool.Dequeue();
            ball.SetActive(true);
            return ball;
        }
        return Instantiate(ballPrefab, parentTransform);
    }

    public void ReturnBall(GameObject ball)
    {
        ball.SetActive(false);
        ballPool.Enqueue(ball);
    }
}