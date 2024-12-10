using UnityEngine;

public class Moltres : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 120;
        Energy = 0;
        stage = 0;
        isCharDeck = true;
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
    public void AssistingHeater()
    {

        if (Energy >= 1)
        {
            BattleManager.instance.doDamage(30, 1);
        }

    }
    public void flameTail()
    {
        AttackDamage = 20;
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(90, 1);
        }
    }
}
