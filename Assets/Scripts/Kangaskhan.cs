using UnityEngine;

public class Kangaskhan : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 120;
        Energy = 0;
        stage = 0;
        isCharDeck = true;
        ActivateUI.SetActive(false);
        AttackUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();
        fainted();
        if (HP <= 0)
        {
            AttackUI.SetActive(false);
        }
    }
    public void Fetch()
    {

        if (Energy >= 1)
        {



        }

    }
    public void Headbutt()
    {
        AttackDamage = 20;
        if (Energy >= 2)
        {
            BattleManager.instance.doDamage(30, 1);
        }
    }
    public void oneTwoPunch()
    {
        if(Energy >=3)
        {
            flipCoint();
            if(isHeads==true)
            {
                BattleManager.instance.doDamage(90, 1);
            }
            if(isHeads==false)
            {
                BattleManager.instance.doDamage(60, 1);
            }
            
        }
    }
}
