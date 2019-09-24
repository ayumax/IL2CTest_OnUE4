// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class IL2CTest : ModuleRules
{
	public IL2CTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });

        var runtimeRoot = Path.Combine(ModuleDirectory, @"..\..\IL2C.Runtime.Artifacts.0.4.93\");

        PublicIncludePaths.AddRange(new string[]
        {
            // IL2C.Runtimeのincludeディレクトリの追加
            Path.Combine(runtimeRoot, @"src\"),
            Path.Combine(runtimeRoot, @"include\"),

            // C#から生成されたCファイルのincludeディレクトリの追加
            Path.Combine(ModuleDirectory, @"src\"),
            Path.Combine(ModuleDirectory, @"include\"),
        });

        // IL2C.Runtime.libの参照追加
        var libRootPath = Path.Combine(runtimeRoot, @"lib\");

        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            if (Target.Configuration == UnrealTargetConfiguration.Debug && Target.bDebugBuildsActuallyUseDebugCRT)
            {
                PublicAdditionalLibraries.Add(libRootPath + "Debug/libil2c-msvc-win-x64-rtd.lib");
            }
            else
            { 
                PublicAdditionalLibraries.Add(libRootPath + "Release/libil2c-msvc-win-x64-rtd.lib");
            }
        }
        else if (Target.Platform == UnrealTargetPlatform.Win32)
        {
            if (Target.Configuration == UnrealTargetConfiguration.Debug && Target.bDebugBuildsActuallyUseDebugCRT)
            {
                PublicAdditionalLibraries.Add(libRootPath + "Debug/libil2c-msvc-win-Win32-rtd.lib");
            }
            else
            {
                PublicAdditionalLibraries.Add(libRootPath + "Release/libil2c-msvc-win-Win32-rtd.lib");
            }
        }
    }
}
