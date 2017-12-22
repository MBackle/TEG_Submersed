

using UnrealBuildTool;
using System.Collections.Generic;

public class TEG_SubmersedTarget : TargetRules
{
	public TEG_SubmersedTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "TEG_Submersed" } );
	}
}
