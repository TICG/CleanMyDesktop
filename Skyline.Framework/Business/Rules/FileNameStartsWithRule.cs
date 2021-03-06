﻿using System;
using System.IO;
using Skyline.Framework.Core;

namespace Skyline.Framework.Business.Rules
{
	public class FileNameStartsWithRule : RuleBase
	{
		public override bool Match(FileInfo file)
		{
			return file.FileNameWithoutExtension().StartsWith(this.Criteria, StringComparison.OrdinalIgnoreCase);
		}
	}
}
