using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeDEfecctor : MonoBehaviour
{
    Rigidbody _rb;
    [SerializeField] Vector3 _force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        _rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerStay(Collider other)
    {
        _rb.AddForce(_force);
    }
}
