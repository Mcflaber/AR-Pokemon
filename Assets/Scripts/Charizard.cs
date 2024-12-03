using UnityEngine;

public class Charizard : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 160;
        Energy = 0;
        isEvolved = true;
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
    public void AbilityResaluteFlame()
    {
        if (Energy >= 0)
        {
            PokemonCard pc = Target.GetComponent<PokemonCard>();
            if (pc != null)
            {
                
            }


        }
    }
    public void FieryBlast()
    {
        if (Energy >= 3)
        {
            PokemonCard pc = Target.GetComponent<PokemonCard>();
            if (pc != null)
            {
                pc.takeDamage(130);
            }
            Energy--;

        }
    }
}
