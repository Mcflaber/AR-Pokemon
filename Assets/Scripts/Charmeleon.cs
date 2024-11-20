using UnityEngine;

public class Charmeleon : PokemonCard
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 100;
        Energy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();
    }
    public void Slash()
    {

    }
    public void flameThrower()
    {

    }
}
