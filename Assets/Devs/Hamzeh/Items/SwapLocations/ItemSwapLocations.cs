using UnityEngine;

public class ItemSwapLocations : BaseItem
{
    protected override void ApplyEffect(Player player)
    {
        SoundManager.instance.PlaySFX(SoundManager.instance.swap);
        Player otherPlayer = itemManager.GetOtherPlayer(player);

        Vector3 currentPosition = player.transform.position;
        Vector3 otherPosition = otherPlayer.transform.position;

        player.transform.position = otherPosition;
       otherPlayer.transform.position = currentPosition;
    }
}
