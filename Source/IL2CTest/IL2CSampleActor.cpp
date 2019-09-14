// Fill out your copyright notice in the Description page of Project Settings.


#include "IL2CSampleActor.h"
#include "include/UE4Il2CSample.h"



// Sets default values
AIL2CSampleActor::AIL2CSampleActor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AIL2CSampleActor::BeginPlay()
{
	Super::BeginPlay();
	
	auto addRet = UE4Il2CSample_Class1_Add__System_Int32_System_Int32(1, 2);

	UE_LOG(LogTemp, Log, TEXT("IL2C add ret = %d"), addRet);
}

// Called every frame
void AIL2CSampleActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

