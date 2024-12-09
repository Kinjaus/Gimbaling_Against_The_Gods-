using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    public CoinType type;
    public int Damage;
}
public enum CoinType { none,Gold,Silver,Copper,Enemy}