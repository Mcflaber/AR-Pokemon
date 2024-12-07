using UnityEngine;

public class EXcharizard : Charmeleon
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 160;
        Energy = 0;
        isEvolved = true;
        isCharDeck = true;
    }

    // Update is called once per frame
    void Update()
    {
        HPField.text = HP.ToString();
        EnergyField.text = Energy.ToString();
        if (isActiveCard == false)
        {
            hideHud();
        }
        else
        {
            showHud();
        }

        fainted();
    }
    public void Flamethrower()
    {
        if (Energy >= 4)
        {
            BattleManager.instance.doDamage(140, 1);
        }
    }
    public void FieryBlast()
    {
        if (Energy >= 4)
        {
            BattleManager.instance.doDamage(300, 1);

        }
    }
}
