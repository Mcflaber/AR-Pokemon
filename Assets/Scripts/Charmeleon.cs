using UnityEngine;

public class Charmeleon : Charmander
{
    public GameObject basic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 100 - DamageTaken;
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
        gameObject.tag = basic.tag;
    }
    public void Slash()
    {
        if (Energy >= 1)
        {
            PokemonCard pc = Target.GetComponent<PokemonCard>();
            if (pc != null)
            {
                pc.takeDamage(30);
            }


        }
    }
    public void flameThrower()
    {
        if (Energy >= 3)
        {
            PokemonCard pc = Target.GetComponent<PokemonCard>();
            if (pc != null)
            {
                pc.takeDamage(80);
            }


        }
    }
}
