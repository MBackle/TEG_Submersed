

using UnrealBuildTool;
using System.Collections.Generic;

public class TEG_SubmersedEditorTarget : TargetRules
{
	public TEG_SubmersedEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "TEG_Submersed" } );
	}
}
