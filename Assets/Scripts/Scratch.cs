using UnityEngine;

public class Scratch : MonoBehaviour
{
    public int attack = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        PokemonCard card = other.GetComponent<PokemonCard>();
        if (card)
        {
            card.takeDamage(attack);
        }
    }
}
