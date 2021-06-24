using System;
using System.Net;

namespace VersionUpdate
{
	class Program
	{
		static void Main(string[] args)
		{
			VersionUpdater versionUpdater = new VersionUpdater();
			versionUpdater.LogFile = "https://raw.githubusercontent.com/1dxrpz/VersionUpdate/master/README.md";

			versionUpdater.Update();
			if (!versionUpdater.IsLatest)
			{
				Console.WriteLine("file outdated");
			}
		}
	}
}
