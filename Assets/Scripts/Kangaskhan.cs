using UnityEngine;

public class Kangaskhan : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();
    }
}
