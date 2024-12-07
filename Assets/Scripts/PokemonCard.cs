using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PokemonCard : MonoBehaviour
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
    public bool isActiveCard = false;
    public bool isEvolved = false;
    public bool isPikaDeck = false;
    public bool isCharDeck = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

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
            HP = 0;
        }
    }
    public void healDamage()
    {
        HP += 30;
        DamageTaken -= 30;
        
    }


            //Example with a manager... 
            // Team number : 1 = CharDeck, 2 = PikaDeck
            // 'this' slots in to paramater of PokemonCard
            //BattleManager.instance.MakeCardActive(TeamNumber, this);

    public void makeActive()
    {
        if (BattleManager.instance.p1ActiveCard != null || BattleManager.instance.p2ActiveCard != null)
        {
            if (isCharDeck == true)
            {
                BattleManager.instance.addBench(gameObject, 1);
            }
            if (isPikaDeck == true)
            {
                BattleManager.instance.addBench(gameObject, 2);
            }














            /*
            if(isCharDeck == true)
            {
                BattleManager.instance.p1Benched[1] = gameObject;
            }
            if (isPikaDeck == true)
            {
                BattleManager.instance.p1Benched = new gameObject[];
            }
            */
        }
        if (isCharDeck == true && isPikaDeck == false)
        {
            BattleManager.instance.p1ActiveCard = gameObject;
            isActiveCard = true;
            ActivateUI.SetActive(false);
        }
        if (isPikaDeck == true && isCharDeck == false) 
        {
            BattleManager.instance.p2ActiveCard = gameObject;
            isActiveCard = true;
            ActivateUI.SetActive(false);
        }

    }
    public void setBenchedCard()
    {
       //BattleManager.instance.p1Benched = ;
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
        BattleManager.instance.clear();
        
    }

}
