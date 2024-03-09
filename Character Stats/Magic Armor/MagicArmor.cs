using System;
using UnityEngine;

[Serializable]
public class MagicArmor
{
    public MagicArmorFromLevel MagicArmorStatLevel;
    public MagicArmorFromCard MagicArmorStatCard;
    public MagicArmorWithTimeBuff MagicArmorStatTimeBuff;

    public MagicArmorStatsContainer MagicArmorCalculator;

    public MagicArmor()
    {
        MagicArmorStatLevel = new MagicArmorFromLevel();
        MagicArmorStatCard = new MagicArmorFromCard();
        MagicArmorStatTimeBuff = new MagicArmorWithTimeBuff();

        MagicArmorCalculator = new MagicArmorStatsContainer();

        MagicArmorCalculator.Add(MagicArmorStatLevel);
        MagicArmorCalculator.Add(MagicArmorStatCard);
        MagicArmorCalculator.Add(MagicArmorStatTimeBuff);
    }

    public float GetBakedMagicArmor
    {
        get
        {
            return MagicArmorCalculator.Calculate();
        }
    }

    public void GetMagicArmorLevel()
    {
        Debug.Log(MagicArmorCalculator.Calculate());
    }

    public async void StartBuff()
    {
        await MagicArmorStatTimeBuff.StartCountdown();
    } 
}
