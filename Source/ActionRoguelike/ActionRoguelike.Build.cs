// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class ActionRoguelike : ModuleRules
{
	public ActionRoguelike(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		// Simplify the include paths in our source files
		PublicIncludePaths.AddRange(
			new string[] {
				"ActionRoguelike"
			}
		);
	
		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core", 
			"CoreUObject", 
			"Engine", 
			"InputCore", 
			"AIModule", 
			"GameplayTasks", 
			"UMG", 
			"GameplayTags", 
			"OnlineSubsystem", 
			"DeveloperSettings",
			"SignificanceManager",
			"EnhancedInput",
			"Niagara"
		});

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
