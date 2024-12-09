using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthManager : MonoBehaviour
{
    //this class keeps track of everyones HP and any modifiers


    [Header("Player")]
    [SerializeField] int pHP;
    [SerializeField] int pMaxHP;
    [SerializeField] Image phpBar;
    //maybe needs damage as well will worry about in a bit


    [Header("Current Enemy")]
    [SerializeField] int eHP;
    [SerializeField] int eMaxHP;
    [SerializeField] Image ehpBar;
    [SerializeField] CoinType weakness;
    [SerializeField] int minDamage, maxDamage;

    void Start()
    {
        
    }

    // Update is called once per frame
    

    public void DamagePlayer()
    {
        //deals the damage
        pHP -= Random.Range(minDamage, maxDamage);
        //updates HP bar, checks if player is dead, keeps them from over healing
        PlayerHPEssentials();
    }

    public void DamageEnemy(Coin co)
    {
        var damage = co.Damage;

        if(co.type==weakness)
        {
            damage = 10;
            //could do times 2 but just means gold weakness isn't as good as copper or silver for balance is my thought
        }
        eHP -= damage;
        //updates HP bar, checks for death
        EnemyHPEssentials();
    }

    #region HP Bar Updates
    private void PlayerHPEssentials()
    {
        //stops from over healing
        if (pHP > pMaxHP) { pHP = pMaxHP; }

        //checks for death
        else if(pHP<=0)
        {
            //call the end of the game for player
        }

        //updates Hp Bar Ui
        phpBar.fillAmount = pHP / pMaxHP;
    }

    private void EnemyHPEssentials()
    {
        //stops from over healing
        if (eHP > eMaxHP) { eHP = eMaxHP; }

        //checks for death
        else if (eHP <= 0)
        {
            //call the end of the round and reward or start next game
        }

        ehpBar.fillAmount = eHP / eMaxHP;
    }

    #endregion
}
