using UnityEngine;

public class Electibuzz : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 80;
        Energy = 0;
        stage = 0;
        isPikaDeck = true;
        ActivateUI.SetActive(false);
        AttackUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();

        fainted();
    }

    public void lowKick()
    {
        if (Energy >= 2)
        {
            BattleManager.instance.doDamage(30, 2);
        }
    }
    public void Thunder()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(90, 2);
            BattleManager.instance.doDamage(30, 1);
        }
    }

}
