using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Patcher;

public static class Patcher
{
	/// <summary>
	/// Called by OWML
	/// </summary>
	public static void Main(string[] args)
	{
		var basePath = args.Length > 0 ? args[0] : ".";
		var gamePath = AppDomain.CurrentDomain.BaseDirectory;
		var folderPath = Path.Combine(gamePath, "MonoBleedingEdge", "EmbedRuntime");
		var from = Path.Combine(basePath, "mono-2.0-bdwgc.dll");
		var to = Path.Combine(folderPath, "mono-2.0-bdwgc.dll");

		try
		{
			if (File.Exists(to)) File.Delete(to);
			File.Copy(from, to);
		}
		catch (UnauthorizedAccessException) // When it is being used
		{
		}
	}
}