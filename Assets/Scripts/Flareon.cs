using UnityEngine;

public class Flareon : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 110;
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
}
