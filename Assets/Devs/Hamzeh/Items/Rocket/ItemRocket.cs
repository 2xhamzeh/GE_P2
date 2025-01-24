using UnityEngine;

public class ItemRocket : MonoBehaviour
{

    private float speed = 30f;
    private float stunDuration = 1.5f;

    private Player targetPlayer;
    private bool isActive = true;

    public void SetTarget(Player target)
    {
        targetPlayer = target;
    }

    private void Update()
    {
        if (!isActive || targetPlayer == null)
        {
            Destroy(gameObject);
            return;
        }

        // Calculate direction to target
        Vector2 direction = ((Vector2)targetPlayer.transform.position - (Vector2)transform.position).normalized;

        // Move towards target
        transform.position += (Vector3)(direction * speed * Time.deltaTime);

        // Rotate rocket to face movement direction
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isActive) return;
        SoundManager.instance.PlaySFX(SoundManager.instance.rocket);
        Player hitPlayer = collision.GetComponent<Player>();
        if (hitPlayer != null && hitPlayer == targetPlayer)
        {
            isActive = false;
            // Stop the player's movement for the stun duration
            hitPlayer.Modifier.ModifyMoveSpeed(0.2f, stunDuration);
            Destroy(gameObject);
        }
    }
}