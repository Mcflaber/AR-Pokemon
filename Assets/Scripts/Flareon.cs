using UnityEngine;

public class Flareon : PokemonCard
{
    public static Flareon instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        HP = 110;
        Energy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
