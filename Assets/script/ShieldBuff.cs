using System;
using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player p)
    {
        p.SetInvulnerbility(true);
    }
}
