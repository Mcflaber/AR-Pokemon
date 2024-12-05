using TMPro;
using UnityEngine;

public class Charmander : PokemonCard
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 70;
        Energy = 0;
        isCharDeck = true;

    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();

        if (isActiveCard == false)
        {
            hideHud();
        }
        else
        {
            showHud();
        }
        Target = GameObject.FindGameObjectWithTag("Active2");
        fainted();
    }
    public void scratch()
    {

        if (Energy >= 1)
        {
            PokemonCard pc = Target.GetComponent<PokemonCard>();
            if (pc != null)
            {
                pc.takeDamage(10);
            }


        }

    }
    public void flameTail()
    {
        AttackDamage = 20;
        if (Energy >= 2)
        {
            PokemonCard pc = Target.GetComponent<PokemonCard>();
            if (pc != null)
            {
                pc.takeDamage(20);
            }
        }
    }
    
}
