using TMPro;
using UnityEngine;

public class Charmander : PokemonCard
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 70;
        Energy = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();
    }
    public void scratch()
    {
        
    }
    public void flameTail()
    {

    }


}
