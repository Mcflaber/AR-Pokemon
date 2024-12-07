using UnityEngine;

public class Pikachu : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 70;
        Energy = 0;
        isPikaDeck = true;
        isCharDeck = false;
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

    public void quickAttack()
    {
        if (Energy >= 1)
        {
            BattleManager.instance.doDamage(10, 2);
        }
    }
    public void electroBall()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(60, 2);
        }
    }

}
