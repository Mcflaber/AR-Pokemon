using UnityEngine;

public class Kangaskhan : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 120;
        Energy = 0;
        isEvolved = false;
        isCharDeck = true;
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();
        if (isActiveCard == false)
        {
            hideHud();
        }
        else
        {
            showHud();
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
            BattleManager.instance.doDamage(60, 1);
        }
    }
}
