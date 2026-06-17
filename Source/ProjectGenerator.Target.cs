// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectGeneratorTarget : TargetRules
{
	public ProjectGeneratorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
// #if UE_4_24_OR_LATER
// 		DefaultBuildSettings = BuildSettingsVersion.V2;
// #endif
		DefaultBuildSettings = BuildSettingsVersion.V5;
		ExtraModuleNames.AddRange( new string[] { "ProjectGenerator" } );
	}
}
