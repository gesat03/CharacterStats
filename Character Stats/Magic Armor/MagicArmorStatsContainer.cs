using System.Collections.Generic;

public class MagicArmorStatsContainer : IStatsContainer
{
    List<IStats> _magicArmorStats = new List<IStats>();

    public void Add(IStats stat)
    {
        _magicArmorStats.Add(stat);
    }

    public void Remove(IStats stat)
    {
        _magicArmorStats.Remove(stat);
    }

    public float Calculate()
    {
        float bakedValue = 0;

        foreach (var stat in _magicArmorStats)
        {
            bakedValue += stat.Calculate();
        }

        return bakedValue;
    }
}
