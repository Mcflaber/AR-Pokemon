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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void showHud()
    {
        Hud.SetActive(true) ;
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
    }
}
