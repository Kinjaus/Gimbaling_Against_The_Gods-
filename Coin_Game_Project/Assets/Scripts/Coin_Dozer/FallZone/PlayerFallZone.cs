using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallZone : _FallZone
{
    HealthManager healthManager;
    // Start is called before the first frame update
    private void Start()
    {
        healthManager = GameObject.Find("Health_Manager").GetComponent<HealthManager>();
    }
    public override void ResolveCoin(GameObject other)
    {
        var coinType = other.GetComponent<Coin>().type;
        
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
