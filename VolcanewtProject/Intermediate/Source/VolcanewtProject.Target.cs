using UnrealBuildTool;

public class VolcanewtProjectTarget : TargetRules
{
	public VolcanewtProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VolcanewtProject");
	}
}
