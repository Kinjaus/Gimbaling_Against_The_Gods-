using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCoinSpawner : MonoBehaviour
{
    bool _isEnemyTurn;
    public GameObject _coinType;
    public GameObject _playerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isEnemyTurn)
        {
            var _coin = Instantiate(_coinType, transform.position, transform.rotation);
            _playerScript.GetComponent<Coin_shoot>().PlayerTurn = true;
            _isEnemyTurn = false;
        }
    }

    public bool IsEnemyTurn
    {
        get { return _isEnemyTurn; }
        set { _isEnemyTurn = value; }
    }
}
