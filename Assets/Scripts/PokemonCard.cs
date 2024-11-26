using TMPro;
using UnityEngine;

public class PokemonCard : MonoBehaviour
{
    
    public int HP;
    public int Energy;
    public int AttackDamage;
    public TextMeshProUGUI HPField;
    public TextMeshProUGUI EnergyField;
    public GameObject Hud;
    public static PokemonCard Instance;
    public bool isActiveCard;
    public GameObject Cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Instance = this;
        isActiveCard = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void setActiveCard()
    {
        isActiveCard = true;
    }
    public void setInactiveCard()
    {
        isActiveCard = false;
    }
    public void showHud()
    {
        if(isActiveCard ==  true)
        {
            Hud.SetActive(true);
        }
        
    }
    public void hideHud()
    {
        Hud.SetActive(false);
    }
    public void addEnergy()
    {
        Energy += 1;
    }
    public void removeEnergy()
    {
        Energy -= 1;
        if(Energy < 0)
        {
            Energy = 0;
        }
    }
    public void fainted()
    {
        if(HP <= 0)
        {
            isActiveCard = false;
        }
    }
    public void takeDamage(int attack)
    {
        HP -= attack;
    }
}
