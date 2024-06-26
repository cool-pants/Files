// Copyright (c) 2024 Files Community
// Licensed under the MIT License. See the LICENSE.

using System.Collections.Generic;
using System.Net;

namespace Files.App.Storage.FtpStorage
{
	public static class FtpManager
	{
		public static readonly Dictionary<string, NetworkCredential> Credentials = [];

		public static readonly NetworkCredential Anonymous = new("anonymous", "anonymous");
	}
}
