using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILoader<Key, Value>
{
	Dictionary<Key, Value> MakeDict();
}

public class DataManager
{
	public Dictionary<int, Data.HeroData> HeroDic { get; private set; } = new Dictionary<int, Data.HeroData>();
	public Dictionary<int, Data.EnemyData> EnemyDic { get; private set; } = new Dictionary<int, Data.EnemyData>();
	public Dictionary<int, Data.EquipmentData> EquipmentDic { get; private set; } = new Dictionary<int, Data.EquipmentData>();
	public Dictionary<int, Data.DefaultSkillData> DefaultSkillDic { get; private set; } = new Dictionary<int, Data.DefaultSkillData>();
	public Dictionary<int, Data.SkillAData> SkillADic { get; private set; } = new Dictionary<int, Data.SkillAData>();
	public Dictionary<int, Data.SkillBData> SkillBDic { get; private set; } = new Dictionary<int, Data.SkillBData>();
	public Dictionary<int, Data.LevelMaterialData> LevelMaterialDic { get; private set; } = new Dictionary<int, Data.LevelMaterialData>();

	public void Init()
	{
		HeroDic = LoadJson<Data.HeroDataLoader, int, Data.HeroData>("HeroData").MakeDict();
		EnemyDic = LoadJson<Data.EnemyDataLoader, int, Data.EnemyData>("EnemyData").MakeDict();
        EquipmentDic = LoadJson<Data.EquipmentDataLoader, int, Data.EquipmentData>("EquipmentData").MakeDict();
        DefaultSkillDic = LoadJson<Data.DefaultSkillDataLoader, int, Data.DefaultSkillData>("DefaultSkillData").MakeDict();
        SkillADic = LoadJson<Data.SkillADataLoader, int, Data.SkillAData>("SkillAData").MakeDict();
        SkillBDic = LoadJson<Data.SkillBDataLoader, int, Data.SkillBData>("SkillBData").MakeDict();
        LevelMaterialDic = LoadJson<Data.LevelMaterialDataLoader, int, Data.LevelMaterialData>("LevelMaterialData").MakeDict();
	}

	private Loader LoadJson<Loader, Key, Value>(string path) where Loader : ILoader<Key, Value>
	{
		TextAsset textAsset = Managers.Resource.Load<TextAsset>(path);
		return JsonConvert.DeserializeObject<Loader>(textAsset.text);
	}
}
