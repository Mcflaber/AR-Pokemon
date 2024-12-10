using UnityEngine;

public class Salazzle : Salandit
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 100;
        Energy = 0;
        stage = 0;
        isCharDeck = true;
        ActivateUI.SetActive(false);
        AttackUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();
        fainted();
        if (HP <= 0)
        {
            ActivateUI.SetActive(false);
        }
    }
    public void FireClaws()
    {

        if (Energy >= 2)
        {
            BattleManager.instance.doDamage(70, 1);
        }

    }

}
