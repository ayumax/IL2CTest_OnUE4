// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class IL2CTest : ModuleRules
{
	public IL2CTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });

        PublicIncludePaths.AddRange(new string[]
        {
            // IL2C.Runtimeのincludeディレクトリの追加
            ModuleDirectory + "/../../native/src/",
            ModuleDirectory + "/../../native/include/",

            // C#から生成されたCファイルのincludeディレクトリの追加
            ModuleDirectory + "/src/",
            ModuleDirectory + "/include/"
        });

        // IL2C.Runtime.libの参照追加
        var libRootPath = ModuleDirectory + "/../../native/lib/";

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
