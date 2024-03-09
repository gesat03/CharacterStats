using System;

[Serializable]
public class MagicArmorFromCard : IStats
{
    public int Number;

    public float Calculate()
    {
        return Number;
    }
}
