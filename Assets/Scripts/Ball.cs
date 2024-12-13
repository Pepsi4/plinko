using UnityEngine;
using Zenject;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    public void Launch(Vector2 force)
    {
        rb.linearVelocity = Vector2.zero;
        rb.AddForce(force, ForceMode2D.Impulse);
    }
}