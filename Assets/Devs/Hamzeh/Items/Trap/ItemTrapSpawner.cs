using UnityEngine;

public class ItemTrapSpawner : BaseItem
{
    [SerializeField] private GameObject trapPrefab;

    protected override void HandleCollection(Player player)
    {
        // Don't return the spawn point, just apply effect
        ApplyEffect(player);
    }

    protected override void ApplyEffect(Player player)
    {
        SoundManager.instance.PlaySFX(SoundManager.instance.trap_spawn);
        itemManager.SpawnTrapAfterDelay(trapPrefab, transform.position, 0.8f, spawnPoint);
    }
}