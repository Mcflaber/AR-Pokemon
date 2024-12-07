using UnityEngine;

public class Flareon : Eevee
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 110;
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
    public void Bite()
    {

        if (Energy >= 1)
        {
            BattleManager.instance.doDamage(20, 1);


        }

    }
    public void FireSpin()
    {
        AttackDamage = 20;
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(130, 1);
            Energy -= 2;
        }
    }
}
