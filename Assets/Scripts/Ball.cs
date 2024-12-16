using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float raycastDistance = 1f;
    [SerializeField] private float launchForce = 5f;
    [SerializeField] private float cooldownDuration = 0.5f;

    private float cooldownTimer;

    private void Update()
    {
        if (cooldownTimer <= 0f)
        {
            CheckAndLaunch();
        }
        else
        {
            cooldownTimer -= Time.deltaTime;
        }
    }

    public void CheckAndLaunch()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance, groundLayer);

        if (hit.collider != null)
        {
            float randomDirection = Random.value < 0.5f ? -1f : 1f;
            Vector2 force = new Vector2(randomDirection * launchForce, launchForce);
            Launch(force);

            cooldownTimer = cooldownDuration;
        }
    }

    public void Launch(Vector2 force)
    {
        rb.linearVelocity = Vector2.zero;
        rb.AddForce(force, ForceMode2D.Impulse);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * raycastDistance);
    }
}
