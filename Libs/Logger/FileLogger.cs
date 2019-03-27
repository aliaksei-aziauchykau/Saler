using System;
using System.IO;
using Newtonsoft.Json;

namespace Logger
{
	public class FileLogger: ILogger
	{
		public void Log(string info, object item, string filePath)
		{
			string infoLog = $"Time: {DateTime.Now}, Info: {info}, Item: {JsonConvert.SerializeObject(item)}";
			using (StreamWriter sw = new StreamWriter(filePath, true))
			{
				sw.WriteLine(infoLog);
			}
		}
	}
}
