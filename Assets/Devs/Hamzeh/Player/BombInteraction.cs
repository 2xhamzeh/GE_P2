using UnityEngine;

public class BombInteraction : MonoBehaviour
{
    private SpriteRenderer bombSprite;
    private Player player;
    private bool canTransferBomb = true;
    private float transferCooldown = 0.5f;

    private void Awake()
    {
        bombSprite = GetComponent<SpriteRenderer>();
        player = transform.parent.GetComponent<Player>();

        if (bombSprite == null)
        {
            Debug.LogError($"No SpriteRenderer found on {gameObject.name}!");
        }
        if (player == null)
        {
            Debug.LogError($"No Player component found on parent of {gameObject.name}!");
        }
    }

    private void Start()
    {
        player.Attributes.OnBombStatusChanged += HandleBombStatusChanged;
    }

    private void OnDestroy()
    {
        if (player != null)
        {
            player.Attributes.OnBombStatusChanged -= HandleBombStatusChanged;
        }
    }

    private void HandleBombStatusChanged(bool hasBomb)
    {
        bombSprite.enabled = hasBomb;
    }

    public void SetBombStatus(bool hasBomb)
    {
        player.Attributes.HasBomb = hasBomb;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Only handle collision if we have the bomb and can transfer
        if (!player.Attributes.HasBomb || !canTransferBomb) return;

        BombInteraction otherBomb = collision.GetComponent<BombInteraction>();
        if (otherBomb != null && otherBomb.canTransferBomb)
        {
            // Prevent both objects from handling the same collision
            canTransferBomb = false;
            otherBomb.canTransferBomb = false;

            SetBombStatus(false);
            otherBomb.SetBombStatus(true);
            otherBomb.SlowOnBombPickup();

            // Reset transfer ability after cooldown for both objects
            Invoke(nameof(ResetTransferAbility), transferCooldown);
            otherBomb.Invoke(nameof(ResetTransferAbility), transferCooldown);
        }
    }

    public void SlowOnBombPickup()
    {
        SoundManager.instance.PlaySFX(SoundManager.instance.bumpInto);
        player.Modifier.ModifyMoveSpeed(0.5f, 0.5f);
    }

    private void ResetTransferAbility()
    {
        canTransferBomb = true;
    }
}