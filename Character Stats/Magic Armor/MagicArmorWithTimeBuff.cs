using System.Threading.Tasks;
using UnityEngine;
using System;

[Serializable]
public class MagicArmorWithTimeBuff : IStats
{
    public int Seconds;
    public float BuffAmount;

    float currentAmount;

    public float Calculate()
    {
        return currentAmount;
    }

    public async Task StartCountdown()
    {
        currentAmount = BuffAmount;
        for (int i = Seconds; i >= 0; i--)
        {
            Debug.Log($"Remaining time: {i} seconds");
            await Task.Delay(1000); // 1 saniye bekle
        }
        currentAmount = 0;
        Debug.Log("Time's up!");
    }
}
