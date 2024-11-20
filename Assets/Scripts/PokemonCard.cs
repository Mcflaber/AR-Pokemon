using TMPro;
using UnityEngine;

public class PokemonCard : MonoBehaviour
{
    
    public int HP;
    public int Energy;
    public TextMeshProUGUI HPField;
    public GameObject Hud;
    public GameObject Camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString() ;
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
