using UnityEngine;

public class Electivire : PokemonCard
{
    public int timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 140;
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

    public void ThunderPunch()
    {
        if (Energy >= 3)
        {
            flipCoint();
            if(isHeads == true)
            {
                BattleManager.instance.doDamage(120, 2);
            }
            else
            {
                BattleManager.instance.doDamage(20, 1);
            }
            timer -= 1;
        }
    }
    public void GigaImpact()
    {
        if (Energy >= 4)
        {
            BattleManager.instance.doDamage(170, 2);
        }
        timer += 1;
    }

}
