using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_shoot : MonoBehaviour
{
    private Vector3 _target;
    [SerializeField] Vector3 _angleOffset;
    public GameObject _crosshare;
    public GameObject _coinPrefab;
    // Start is called before the first frame update
    LayerMask _layerMask;
    void Start()
    {
        Cursor.visible = true;
        _layerMask = LayerMask.GetMask("ShootZone"); //Items allowing the raycast to hit.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit,Mathf.Infinity,_layerMask))
            {
                //Debug.DrawRay(transform.position,transform.TransformDirection(Vector3.forward)*hit.distance, Color.yellow);
                var _rotation = _coinPrefab.transform.rotation;
                
                var _coin = Instantiate(_coinPrefab, Camera.main.transform.position, _rotation);

                var _coinAngle = hit.point - Camera.main.transform.position+_angleOffset;
                Debug.Log(ray);
                _coin.GetComponent<Rigidbody>().AddForce(_coinAngle, ForceMode.Impulse);
            }
        }
    }
}
