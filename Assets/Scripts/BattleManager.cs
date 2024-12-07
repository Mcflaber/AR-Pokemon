using System;
using Unity.VisualScripting;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject p1ActiveCard;
    public GameObject p2ActiveCard;
    public GameObject[] p1Benched = new GameObject[5];
    public GameObject[] p2Benched = new GameObject[5];
    int benchedIndex = 1;
    int benchedIndex2 = 1;
    public int[] test = new int[5];
    public static BattleManager instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void doDamage(int AttackDamage, int team)
    {
        PokemonCard P1 = p1ActiveCard.GetComponent<PokemonCard>();
        PokemonCard P2 = p2ActiveCard.GetComponent<PokemonCard>();

        if (P1 != null && team == 1)
        {
            P2.takeDamage(AttackDamage);
        }
        if (P2 != null && team == 2)
        {
            P1.takeDamage(AttackDamage);
        }



    }
    public void clear()
    {
        PokemonCard P1 = p1ActiveCard.GetComponent<PokemonCard>();
        PokemonCard P2 = p2ActiveCard.GetComponent<PokemonCard>();
        if (P1.HP <= 0)
        {
            p1ActiveCard = null;
        }
        if (P2.HP <= 0)
        {
            p2ActiveCard = null;
        }

    }
    public void addBench(GameObject card, int team)
    {
        if(team == 1)
        {
                p1Benched[benchedIndex] = card;
            benchedIndex++;   
        }
        if (team == 2)
        {
            for (int k = 0; k <= 5; k++)
            {
                p2Benched[benchedIndex2] = card;
                benchedIndex++;

            }
        }
    }

}
