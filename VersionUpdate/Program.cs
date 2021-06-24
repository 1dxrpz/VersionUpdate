using System;
using System.Net;

namespace VersionUpdate
{
	class Program
	{
		static void Main(string[] args)
		{
			string data;
			using (WebClient client = new WebClient())
			{
				data = client.DownloadString("https://raw.githubusercontent.com/1dxrpz/VersionUpdate/master/README.md");
			}
			Console.WriteLine(data);
		}
	}
}
