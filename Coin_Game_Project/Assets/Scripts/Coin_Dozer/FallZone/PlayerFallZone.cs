using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallZone : _FallZone
{
    HealthManager healthManager;
    // Start is called before the first frame update
    private void Start()
    {
        healthManager =  FindObjectOfType<HealthManager>();
    }
    public override void ResolveCoin(GameObject other)
    {
        var coinType = other.gameObject.GetComponent<Coin>().type;
        
        switch (coinType)
        {
            case CoinType.Enemy:
                healthManager.DamagePlayer();
                break;
            default:
                healthManager.DamageEnemy(other.GetComponent<Coin>());
                break;

        }
    }
}
