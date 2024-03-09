using System;

[Serializable]
public class MagicArmorFromLevel : IStats
{
    public float Level = 0;

    public float Calculate()
    {
        return 4.39f + (0.593f * Level) + (0.0118f * Level * Level) + (0.00039f * Level * Level * Level);
    }
}
