using TMPro;
using UnityEngine;

public class PokemonCard : MonoBehaviour
{
    
    public int HP;
    public int Energy;
    public TextMeshProUGUI HPField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString() ;
    }

}
