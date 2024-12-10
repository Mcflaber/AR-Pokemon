using Unity.VisualScripting;
using UnityEngine;

public class Charmeleon : PokemonCard
{
    public GameObject Charmander;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Charmander pc = GetComponent<Charmander>();
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
        if (BattleManager.instance.p1ActiveCard == null)
        {
            ActivateUI.SetActive(true);
        }
        fainted();
        getStats();
    }
    public void Slash()
    {
        if (Energy >= 2)
        {
            BattleManager.instance.doDamage(30, 1);


        }
    }
    public void flameThrower()
    {
        if (Energy >= 3)
        {
            BattleManager.instance.doDamage(60, 1);


        }
    }
    public void getStats()
    {
        Charmander pc = GetComponent<Charmander>();
        HP = 100 - pc.DamageTaken;
        Energy = pc.Energy;
    }
}
