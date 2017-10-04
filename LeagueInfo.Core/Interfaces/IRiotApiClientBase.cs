namespace LeagueInfo.Core.Contract
{
	public interface IRiotApiClientBase<T>
	{
		T GetData(string resourceId);
	}
}
