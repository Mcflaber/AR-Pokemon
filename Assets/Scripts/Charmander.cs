using TMPro;
using UnityEngine;

public class Charmander : PokemonCard
{
    public Animator anim;
    public bool usingScratch = false;
    public bool usingFlameTail = false;
    
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
        AttackDamage = 10;
        if(Energy >= 1)
        {
            anim.Play("Attack", 0, 0);
            usingScratch = true;
        }

    }
    public void flameTail()
    {
        AttackDamage = 20;
        if (Energy >= 2)
        {

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        PokemonCard Card = other.gameObject.GetComponentInParent<PokemonCard>();
        if(Card)
        {
            Debug.Log("Hit");
        }    

    }


}
