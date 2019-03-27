namespace Logger
{
	public interface ILogger
	{
		void Log(string info, object item, string specific);
	}
}
