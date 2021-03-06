﻿using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;

namespace FluffySpoon.AspNet.LetsEncrypt.Azure
{
	public class AzureOptions
	{
		public string ResourceGroupName { get; set; }
		public string Slot { get;set; }

		public AzureCredentials Credentials { get; set; }
	}
}
