using UnityEngine;


public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField]public bool isEffectActive = false;
    Player player;

    private void OnTriggerEnter2D(Collider2D Player)
    {
       if(player)
        {
            isEffectActive = true;
            ApplyEffect(player);
        } 
    }

    public abstract void ApplyEffect(Player p);
}
