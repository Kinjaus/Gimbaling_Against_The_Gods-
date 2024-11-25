using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFallZone : _FallZone
{
    // Start is called before the first frame update
    public override void ResolveCoin(GameObject other)
    {
        switch (other.tag)
        {
            case "copper":
                break;
            case "silver":
                break;
            case "gold":
                break;
            case "bad":
                break;
            default:
                break;
        }
    }
}
