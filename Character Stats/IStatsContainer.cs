public interface IStatsContainer : IStats
{
    public void Add(IStats stat);

    public void Remove(IStats stat);
}
