﻿using System.Configuration;

namespace Scooterland.Server.DataAccess.SQLClient
{
	public class ConnectionHandlerSQLClient
	{
		public string GetConnectionString()
		{
			return System.Configuration.ConfigurationManager.ConnectionStrings["Hjalte"].ToString();
		}
	}
}
