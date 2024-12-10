using TMPro;
using UnityEngine;

public class Charmander : PokemonCard
{
    public GameObject charmeleon;
    public static Charmander instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 70;
        Energy = 0;
        isCharDeck = true;
        stage = 0;
        ActivateUI.SetActive(false);
        AttackUI.SetActive(false);
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();
        if(BattleManager.instance.p1ActiveCard == null )
        {
            ActivateUI.SetActive(true);
        }

        fainted();
    }
    public void scratch()
    {

        if (Energy >= 1)
        {
            BattleManager.instance.doDamage(10, 1);


        }

    }
    public void flameTail()
    {
        AttackDamage = 20;
        if (Energy >= 2)
        {
            BattleManager.instance.doDamage(20, 1);
        }
    }
    public void evolve()
    {
        Charmeleon stage2 = charmeleon.GetComponent<Charmeleon>();
        if (isActiveCard == true)
        {
            BattleManager.instance.activarte(charmeleon, 1);
            stage2.isActiveCard = true;
            
        }
        if (inPlay == true && isActiveCard == false)
        {
            BattleManager.instance.subBench(gameObject, 1);
            BattleManager.instance.addBench(charmeleon, 1);
        }
    }
}
