using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PokemonCard : BattleManager
{

    public int HP = 0;
    public int DamageTaken = 0; 
    public int Energy = 0;
    public int AttackDamage = 0;
    public int numberofActiveCards = 0;
    public TextMeshProUGUI HPField;
    public TextMeshProUGUI EnergyField;
    public GameObject AttackUI;
    public GameObject ActivateUI;
    public GameObject Target;
    public bool isActiveCard = false;
    public bool isActive2Card = false;
    public bool isEvolved = false;
    public bool isPikaDeck = false;
    public bool isCharDeck = false;

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
    public void healDamage()
    {
        HP += 30;
        DamageTaken -= 30;
        
    }
    public void setActiveCard(int teamNumber)
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
    public void makeActive()
    {
        BattleManager.instance.p1ActiveCard = gameObject;
    }
    public void setBenchedCard()
    {
        if(p1ActiveCard != null && p2ActiveCard != null)
        {
            isActiveCard = false;
        }
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
