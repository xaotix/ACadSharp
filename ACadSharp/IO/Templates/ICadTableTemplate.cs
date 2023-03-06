using System.Collections.Generic;

namespace ACadSharp.IO.Templates
{
	internal interface ICadTableTemplate : ICadObjectTemplate
	{
		CadObject CadObject { get; set; }

		List<ulong> EntryHandles { get; }
	}
}
