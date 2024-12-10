using UnityEngine;

public class EXcharizard : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 160;
        Energy = 0;
        stage = 0;
        isCharDeck = true;
        ActivateUI.SetActive(false);
        AttackUI.SetActive(false);
        isGx = true;
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();
        fainted();
    }
    public void Flamethrower()
    {
        if (Energy >= 4)
        {
            BattleManager.instance.doDamage(140, 1);
        }
    }
    public void FlareBlitzGX()
    {
        if (Energy >= 4 && BattleManager.instance.exMove > 0)
        {
            BattleManager.instance.doDamage(300, 1);
            BattleManager.instance.exMove -= 1;
        }
    }
}
