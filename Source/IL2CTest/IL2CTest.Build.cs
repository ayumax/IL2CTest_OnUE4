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
            // IL2C.Runtime��include�f�B���N�g���̒ǉ�
            ModuleDirectory + "/../../native/src/",
            ModuleDirectory + "/../../native/include/",

            // C#���琶�����ꂽC�t�@�C����include�f�B���N�g���̒ǉ�
            ModuleDirectory + "/src/",
            ModuleDirectory + "/include/"
        });

        // IL2C.Runtime.lib�̎Q�ƒǉ�
        if (Target.Platform == UnrealBuildTool.UnrealTargetPlatform.Win64)
        {
            PublicAdditionalLibraries.Add(ModuleDirectory + "/../../native/lib/Release/libil2c-msvc-win-x64-rtd.lib");
        }
        else if (Target.Platform == UnrealBuildTool.UnrealTargetPlatform.Win32)
        {
            PublicAdditionalLibraries.Add(ModuleDirectory + "/../../native/lib/Release/libil2c-msvc-win-Win32-rtd.lib");
        }
    }
}
