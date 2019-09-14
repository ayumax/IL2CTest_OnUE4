// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#include "IL2CTestGameMode.h"
#include "IL2CTestHUD.h"
#include "IL2CTestCharacter.h"
#include "UObject/ConstructorHelpers.h"

AIL2CTestGameMode::AIL2CTestGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = AIL2CTestHUD::StaticClass();
}
