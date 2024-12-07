using UnityEngine;

public class Charmeleon : Charmander
{
    public GameObject basic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 100 - DamageTaken;
        Energy = 0;
        isEvolved = true;
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
        fainted();
    }
    public void Slash()
    {
        if (Energy >= 2)
        {
            BattleManager.instance.doDamage(30, 1);


        }
    }
    public void flameThrower()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(60, 1);


        }
    }
}
