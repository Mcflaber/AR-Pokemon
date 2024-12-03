using TMPro;
using UnityEngine;

public class PokemonCard : MonoBehaviour
{

    public int HP;
    public int Energy;
    public int AttackDamage;
    public int numberofActiveCards;
    public TextMeshProUGUI HPField;
    public TextMeshProUGUI EnergyField;
    public GameObject AttackUI;
    public GameObject ActivateUI;
    public static PokemonCard Instance;
    public GameObject Target;
    public bool isActiveCard;
    public bool isActive2Card;
    public bool isEvolved;

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


    public void takeDamage(int attack)
    {
        HP -= attack;
    }
    public void setActiveCard()
    {
        if(numberofActiveCards == 0 )
        {
            transform.gameObject.tag = "Active";
            isActiveCard = true;
            ActivateUI.SetActive(false);
        }
        else if ( numberofActiveCards == 1 )
        {
            transform.gameObject.tag = "Active2";
            isActiveCard = true;
            ActivateUI.SetActive(false);
        }

    }
    public void setBenchedCard()
    {
        isActiveCard = false;
    }
    public void showHud()
    {
        AttackUI.SetActive(true);

    }
    public void hideHud()
    {
        AttackUI.SetActive(false);

    }
    public void addEnergy()
    {
        Energy += 1;
    }
    public void removeEnergy()
    {
        Energy -= 1;
        if (Energy < 0)
        {
            Energy = 0;
        }
    }
    public void fainted()
    {
        if (HP <= 0)
        {
            isActiveCard = false;
        }
    }

}
