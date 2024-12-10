using UnityEngine;

public class Eevee : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 60;
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
        if (HP <= 0)
        {
            AttackUI.SetActive(false);
        }
    }
    public void Gnaw()
    {

        if (Energy >= 1)
        {
            BattleManager.instance.doDamage(20, 1);


        }

    }

}
