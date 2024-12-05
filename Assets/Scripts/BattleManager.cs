using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using Unity.VisualScripting;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject p1ActiveCard;
    public GameObject p2ActiveCard;
    public GameObject[] p1Benched = new GameObject [5];
    public GameObject[] p2Benched = new GameObject [5];
    public static BattleManager instance;
    PokemonCard PC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        PC = p1ActiveCard.GetComponent<PokemonCard>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
