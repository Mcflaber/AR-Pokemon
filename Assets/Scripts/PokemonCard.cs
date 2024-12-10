using System.Security.Cryptography;
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
    public GameObject evolution1;
    public GameObject evolution2;
    public GameObject EnergyUI;
    public bool inPlay = false;
    public bool isActiveCard = false;
    public int stage = 0;
    public bool isPikaDeck = false;
    public bool isCharDeck = false;
    public bool canEvolve = false;
    public bool isGx = false;
    public int randomNum = 0;
    public bool isHeads = false;
    public bool hasFainted = false;
    public bool isBenched = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ActivateUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (BattleManager.instance.p1ActiveCard == null && isCharDeck == true)
        {
            ActivateUI.SetActive(true);
        }
        if (BattleManager.instance.p2ActiveCard == null && isPikaDeck == true)
        {
            ActivateUI.SetActive(true);
        }
    }
    private void OnMouseDown()
    {
        if(isActiveCard == false && inPlay == false)
        {
            makeActive();
            EnergyUI.SetActive(true);
        }
        if(isBenched== true)
        {
            ActivateUI.SetActive(true);
            EnergyUI.SetActive(true);
        }
    }

    public void takeDamage(int attack)
    {
        HP -= attack;
        DamageTaken += attack;
        if (HP <= 0)
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
        if (BattleManager.instance.p1ActiveCard == null)
        {
            if (isCharDeck == true && isPikaDeck == false && stage == 0)
            {
                BattleManager.instance.p1ActiveCard = gameObject;
                inPlay = true;
                isActiveCard = true;
                ActivateUI.SetActive(false);
                AttackUI.SetActive(true);
            }
        }
        if (BattleManager.instance.p2ActiveCard == null)
        {
            if (isPikaDeck == true && isCharDeck == false && stage == 0)
            {
                BattleManager.instance.p2ActiveCard = gameObject;
                inPlay = true;
                isActiveCard = true;
                ActivateUI.SetActive(false);
                AttackUI.SetActive(true);
            }
        }
        if (BattleManager.instance.p1ActiveCard != null && inPlay == false && stage == 0 || BattleManager.instance.p2ActiveCard != null && inPlay == false && stage == 0)
        {
            inPlay = true;
            isActiveCard = false;
            setBenchedCard();
            return;

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

    }
    public void setBenchedCard()
    {
        if (isCharDeck == true)
        {
            inPlay = true;
            BattleManager.instance.addBench(gameObject, 1);
        }
        if (isPikaDeck == true)
        {
            inPlay = true;
            BattleManager.instance.addBench(gameObject, 2);
        }
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

        if (isCharDeck == true && isGx == true && HP <= 0)
        {
            BattleManager.instance.p1FaintedPokemon += 2;
        }
        if (isPikaDeck == true && isGx == true && HP <= 0)
        {
            BattleManager.instance.p2FaintedPokemon += 2;
        }
    }
    public void flipCoint()
    {
        randomNum = Random.Range(0, 100);
        if (randomNum % 2 == 0)
        {
            isHeads = true;
        }
    }

}
