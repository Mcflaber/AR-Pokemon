using UnityEngine;

public class Raichu : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 110;
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

    public void quickAttack()
    {
        if (Energy >= 1)
        {
            flipCoint();
            if (isHeads == true)
            {
                BattleManager.instance.doDamage(40, 2);
            }
            else
            {
                BattleManager.instance.doDamage(10, 2);
            }
            
        }
    }
    public void ElectricSurfer()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(70, 2);
        }
    }

}
