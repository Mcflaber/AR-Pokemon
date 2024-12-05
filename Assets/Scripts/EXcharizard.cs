using UnityEngine;

public class EXcharizard : Charmeleon
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
    public void Flamethrower()
    {
        if (Energy >= 4)
        {
            PokemonCard pc = Target.GetComponent<PokemonCard>();
            if (pc != null)
            {
                pc.takeDamage(140);
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
                pc.takeDamage(300);
            }
            Energy--;

        }
    }
}
