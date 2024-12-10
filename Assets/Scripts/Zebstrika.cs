using UnityEngine;

public class Zebstrika : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 120;
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
        if (HP <= 0)
        {
            AttackUI.SetActive(false);
        }
        fainted();
    }

    public void Raid()
    {
        if (Energy >= 2)
        {
            BattleManager.instance.doDamage(30, 2);
        }
    }
    public void MachBolt()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(100, 2);
        }
    }

}
