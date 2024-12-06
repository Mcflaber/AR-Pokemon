using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using Unity.VisualScripting;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject p1ActiveCard;
    public GameObject p2ActiveCard;
    public GameObject[] p1Benched = new GameObject[5];
    public GameObject[] p2Benched = new GameObject[5];
    public static BattleManager instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (BattleManager.instance.p1ActiveCard != null)
        {
            Debug.Log("full");
        }
    }
    public void doDamagetoP1(int AttackDamage)
    {     
         PokemonCard P1 = p1ActiveCard.GetComponent<PokemonCard>();
        PokemonCard P2 = p2ActiveCard.GetComponent<PokemonCard>();

        if (P1.isCharDeck == true && P1.isPikaDeck == false && P1 != null)
        {
            P1.takeDamage(AttackDamage);
        }
        else if (P2.isPikaDeck == true && P1.isCharDeck == false && P2 != null)
        {
            P2.takeDamage(AttackDamage);
        }



    }
    public void doDamagetoP2(int AttackDamage)
    {


        PokemonCard pc = p2ActiveCard.GetComponent<PokemonCard>();
        if (pc != null)
        {
            pc.takeDamage(AttackDamage);
        }




    }
}
