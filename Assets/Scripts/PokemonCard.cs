using TMPro;
using UnityEngine;

public class PokemonCard : MonoBehaviour
{

    public int HP = 0;
    public int DamageTaken = 0; 
    public int Energy;
    public int AttackDamage;
    public int numberofActiveCards;
    public TextMeshProUGUI HPField;
    public TextMeshProUGUI EnergyField;
    public GameObject AttackUI;
    public GameObject ActivateUI;
    public GameObject Target;
    public bool isActiveCard;
    public bool isActive2Card;
    public bool isEvolved;
    public bool isPikaDeck;
    public bool isCharDeck;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isActiveCard = false;

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void takeDamage(int attack)
    {
        HP -= attack;
        DamageTaken += attack;
        if(HP <= 0)
        {
            fainted();
        }
    }
    public void setActiveCard()
    {
        if(isCharDeck == true)
        {
            transform.gameObject.tag = "Active";
            isActiveCard = true;
            ActivateUI.SetActive(false);

            //Example with a manager... 
            // Team number : 1 = CharDeck, 2 = PikaDeck
            // 'this' slots in to paramater of PokemonCard
            //BattleManager.instance.MakeCardActive(TeamNumber, this);
        }
        if(isPikaDeck == true)
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
        if(HP <= 0)
        {
            isActiveCard = false;
            
            HP = 0;
        }
            
        
    }

}
