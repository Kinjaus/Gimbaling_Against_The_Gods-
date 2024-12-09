using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallZone : _FallZone
{
    // Start is called before the first frame update
    
    public override void ResolveCoin(GameObject other)
    {
        //HealthManager healthManager;
        
        switch (other.tag)
        {
            case "copper":
                //healthManager.DamageEnemy();
                break;
            case "silver":
                //healthManager.DamageEnemy();
                break;
            case "gold":
                //healthManager.DamageEnemy();
                break;
            case "bad":
                //healthManager.DamagePlayer();
                break;
            default:
                break;

        }
    }
}
