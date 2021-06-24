using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace VersionUpdate
{
	public class VersionUpdater
	{
		public string LogFile = "";
		public string CurrentLog = "";
		public string ServerLog
		{
			get
			{
				using (WebClient client = new WebClient())
					return client.DownloadString(LogFile);
			}
		}
		public bool IsLatest
		{
			get
			{
				using (WebClient client = new WebClient())
					return CurrentLog == ServerLog;
			}
		}
		public void Update() => CurrentLog = ServerLog;
	}
}
