using System;
using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player p)
    {
        p.SetMoveSpeed(2);
    }
}
