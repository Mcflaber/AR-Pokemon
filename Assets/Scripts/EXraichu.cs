using UnityEngine;

public class EXraichu : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 210;
        Energy = 0;
        stage = 0;
        isPikaDeck = true;
        ActivateUI.SetActive(false);
        AttackUI.SetActive(false);
        isGx=true;
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();

        fainted();
    }

    public void TunderBolt()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(120, 2);
        }
    }
    public void SparkballGX()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(200, 1);
            BattleManager.instance.exMove -= 1;
        }
    }

}
