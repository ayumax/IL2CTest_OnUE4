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
        PublicAdditionalLibraries.Add(ModuleDirectory + "/../../native/x64/Release/IL2C.Runtime.lib");

    }
}
