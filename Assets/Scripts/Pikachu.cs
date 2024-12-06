using UnityEngine;

public class Pikachu : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 70;
        Energy = 0;
        isPikaDeck = true;
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
        Target = GameObject.FindGameObjectWithTag("Active");
        fainted();
    }

    public void quickAttack()
    {
        if (Energy >= 1)
        {
            BattleManager.instance.doDamagetoP1(10);
        }
    }
    public void electroBall()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamagetoP1(60);
        }
    }

}
