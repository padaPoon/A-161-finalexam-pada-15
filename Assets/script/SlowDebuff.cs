using System;
using UnityEngine;

public class SlowDebuff : PowerUpBase
{
    public override void ApplyEffect(Player p)
    {
        p.DebuffSpeed(2);
    }
}
