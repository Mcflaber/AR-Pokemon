using TMPro;
using UnityEngine;

public class Charmander : PokemonCard
{
    public BoxCollider BC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 70;
        Energy = 0;
        BC = GetComponent<BoxCollider>();
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
            //BC.SetActive(true);
        }

    }
    public void flameTail()
    {
        if (Energy >= 2)
        {

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }


}
