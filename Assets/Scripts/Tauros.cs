using UnityEngine;

public class Tauros : PokemonCard
{
    public GameObject call;
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

    public void callForFamily()
    {
        if (Energy >= 1)
        {
            call.SetActive(true);
        }
    }
    public void BerserkerTackle()
    {
        if (Energy >= 2)
        {
            BattleManager.instance.doDamage(60, 2);
            BattleManager.instance.doDamage(10, 1);
        }
    }
    public void turnoff()
    {
        call.SetActive(false);
    }
}
