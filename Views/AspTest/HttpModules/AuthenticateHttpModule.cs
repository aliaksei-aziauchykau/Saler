using System;
using System.Web;
using Logger;

namespace AspTest.HttpModules
{
	public class AuthenticateHttpModule: IHttpModule
	{
		public void Init(HttpApplication context)
		{
			context.BeginRequest += Application_BeginRequest;
		}

		private void Application_BeginRequest(object sender, EventArgs eventArgs)
		{
			ILogger logger = new FileLogger();
			logger.Log("Initial request", new object(), @"D:\MELOGS");
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}