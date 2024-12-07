using UnityEngine;

public class Salandit : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 70;
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
    public void liveCoal()
    {
        if (Energy >= 1)
        {
            BattleManager.instance.doDamage(10, 1);
        }
    }
    public void Combustion()
    {
        if (Energy >= 2)
        {
            BattleManager.instance.doDamage(30, 1);
        }
    }
}
