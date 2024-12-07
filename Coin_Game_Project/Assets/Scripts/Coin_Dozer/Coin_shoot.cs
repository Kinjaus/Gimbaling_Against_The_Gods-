using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_shoot : MonoBehaviour
{
    private Vector3 _target;
    [SerializeField] Vector3 _angleOffset;
    public GameObject _coinPrefab;
    // Start is called before the first frame update
    LayerMask _layerMask;
    Rigidbody _rb;
    void Start()
    {
        Cursor.visible = true;
        _layerMask = LayerMask.GetMask("ShootZone"); //Items allowing the raycast to hit.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            GetCoinType("CopperCoin");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            GetCoinType("SilverCoin");        
        }
        if (Input .GetKeyDown(KeyCode.Alpha3)) 
        {
            GetCoinType("GoldCoin");
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit,Mathf.Infinity,_layerMask))
            {
                //Debug.DrawRay(transform.position,transform.TransformDirection(Vector3.forward)*hit.distance, Color.yellow);
                var _rotation = _coinPrefab.transform.rotation;
                _rb = _coinPrefab.GetComponent<Rigidbody>();


                var _coin = Instantiate(_coinPrefab, Camera.main.transform.position, _rotation);
                _rb = _coin.GetComponent<Rigidbody>();
                _rb.isKinematic = false;

                var _coinAngle = hit.point - Camera.main.transform.position+_angleOffset;
                Debug.Log(ray);
                _coin.GetComponent<Rigidbody>().AddForce(_coinAngle, ForceMode.Impulse);
            }
        }
    }

    void GetCoinType (string name)
    {
        _coinPrefab = GameObject.Find(name);
    }
}
