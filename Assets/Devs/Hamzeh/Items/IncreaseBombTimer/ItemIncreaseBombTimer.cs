using UnityEngine;

public class ItemIncreaseBombTimer : BaseItem
{
    protected override void ApplyEffect(Player player)
    {
        SoundManager.instance.PlaySFX(SoundManager.instance.pickUp);
        float currentTimer = itemManager.GetBombTimer();
        itemManager.SetBombTimer(currentTimer + 5.0f);
    }
}
