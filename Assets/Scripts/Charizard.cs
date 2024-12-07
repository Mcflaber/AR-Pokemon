using UnityEngine;

public class Charizard : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 160 - DamageTaken;
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
    public void AbilityResaluteFlame()
    {
        if (Energy >= 0)
        {
            BattleManager.instance.doDamage(0, 1);

        }
    }
    public void FieryBlast()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(130, 1);

        }
    }
}
