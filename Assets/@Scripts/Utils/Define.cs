using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Define
{
	public enum EScene
	{
		Unknown,
		TitleScene,
		GameScene,
		LoadingScene,
		LobbyScene
	}

	public enum EUIEvent
	{
		Click,
		PointerDown,
		PointerUp,
		Drag,
	}

	public enum ESound
	{
		Bgm,
		Effect,
		Max,
	}


    //Character ID
    //Hero ID
    public const int HeroHwarangID = 0;
	public const int HeroCheongryuID = 1;
	public const int HeroSeorokID = 2;
	public const int HeroHeukryeongID = 3;
	public const int HeroHyeongwangID = 4;

    //Enemy ID
    public const int EnemyHwayeonID = 0;
    public const int EnemyJeokhwaID = 1;
    public const int EnemyYeomshinID = 2;
    public const int EnemyBulkkotgyeolID = 3;
    public const int EnemyHwangyeomID = 4;
    public const int EnemyLavasID = 5;
    public const int EnemyYeolpungID = 6;
    public const int EnemyHongyeomID = 7;
    public const int EnemyBulmyeoljaID = 8;
    public const int EnemyAsheraID = 9;

    //Equipment ID
    public const int EquipmentLeatherChestID = 0;
    public const int EquipmentLeatherPitchID = 1;
    public const int EquipmentSwordID = 2;
    public const int EquipmentPistolID = 3;
    public const int EquipmentShieldID = 4;

	//Skill ID
	//Default
	public const int DefaultSkillShortFireAttackID = 0;
	public const int DefaultSkillLongFireAttackID = 1;
	public const int DefaultSkillMagicFireAttackID = 2;
    public const int DefaultSkillShortWaterAttackID = 3;
    public const int DefaultSkillLongWaterAttackID = 4;
    public const int DefaultSkillMagicWaterAttackID = 5;
    public const int DefaultSkillShortGrassAttackID = 6;
    public const int DefaultSkillLongGrassAttackID = 7;
	public const int DefaultSkillMagicGrassAttackID = 8;
    public const int DefaultSkillShortDarkAttackID = 9;
    public const int DefaultSkillLongDarkAttackID = 10;
    public const int DefaultSkillMagicDarkAttackID = 11;
    public const int DefaultSkillShortLightAttackID = 12;
    public const int DefaultSkillLongLightAttackID = 13;
    public const int DefaultSkillMagicLightAttackID = 14;

	//A
	public const int SkillAFireBlastID = 0;
	public const int SkillAAquaSlashID = 1;
	public const int SkillAVineGrabID = 2;
	public const int SkillAShadowClawID = 3;
	public const int SkillASwordOfRadianceID = 4;

    //B
    public const int SkillBBurningFlameID = 0;
    public const int SkillBTidalWaveID = 1;
    public const int SkillBFuryOfNatureID = 2;
    public const int SkillBDarkMistID = 3;
    public const int SkillBLightBreakerID = 4;

    //Level Material ID
    public const int LevelMaterialHeroCommonExpBookID = 0;
    public const int LevelMaterialHeroUncommonExpBookID = 1;
    public const int LevelMaterialHeroRareExpBookID = 2;
    public const int LevelMaterialHeroEpicExpBookID = 3;
    public const int LevelMaterialHeroLegendaryExpBookID = 4;
    public const int LevelMaterialArmCommonExpBookID = 5;
    public const int LevelMaterialArmUncommonExpBookID = 6;
    public const int LevelMaterialArmRareExpBookID = 7;
    public const int LevelMaterialArmEpicExpBookID = 8;
    public const int LevelMaterialArmLegendaryExpBookID = 9;
    public const int LevelMaterialUnburnableBranchID = 10;
    public const int LevelMaterialWaterabsorbingBranchID = 11;
    public const int LevelMaterialMilkHoneyBranchID = 12;
    public const int LevelMaterialVoidBranchID = 13;
    public const int LevelMaterialBloodBranchID = 14;


    public enum Attribute_Type
    {
        None = -1,
        Fire = 0,
        Water = 1,
        Grass = 2,
        Dark = 3,
        Light = 4,
    }

    public enum Grade
    {
        None = -1,
        Common = 0,
        Uncommon = 1,
        Rare = 2,
        Epic = 3,
        Legendary = 4,
    }
}
