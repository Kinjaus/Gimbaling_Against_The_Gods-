using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _FallZone : MonoBehaviour
{
    // Start is called before the first frame update


    public virtual void OnTriggerEnter(Collider other)
    {
        ResolveCoin(other.gameObject);
        Destroy(other.gameObject);
        
    }

    public virtual void ResolveCoin(GameObject other)
    {
        
    }

    public void DestoryCoin(GameObject other)
    {
        Destroy(other);
    }

}
