using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCharacterStats : MonoBehaviour
{
    public MagicArmor Magic_Armor;

    public float BakedMagicArmor;

    private void Start()
    {
        Magic_Armor = new MagicArmor();
    }

    private void Update()
    {
        BakedMagicArmor = Magic_Armor.GetBakedMagicArmor;
    }

    [ContextMenu("GetMagicArmorLevel")]
    public void GetMagicArmorLevel()
    {
        Magic_Armor.GetMagicArmorLevel();
    }

    [ContextMenu("StartBuff")]
    public void StartBuff()
    {
        Magic_Armor.StartBuff();
    }

}
