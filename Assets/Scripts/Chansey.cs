using UnityEngine;

public class Chansey : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 130;
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

    public void DoubleEdge()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(10, 2);
            BattleManager.instance.doDamage(20, 1);
        }
    }


}
