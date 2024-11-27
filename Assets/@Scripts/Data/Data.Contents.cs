using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Data
{
    #region CreatureData
    [Serializable]
    public class CreatureData
    {
        public int DataId;
        public string Name;
        public string Description;
        public float Attack;
        public float Defence;
        public float SkillDamage;
        public string Type;
        public string Grade;
        public int DefaultSkill;
        public int SkillA;
        public int SkillB;
    }
    #endregion

    #region HeroData
    [Serializable]
    public class HeroData : CreatureData { }

    [Serializable]
    public class HeroDataLoader : ILoader<int, HeroData>
    {
        public List<HeroData> hero = new List<HeroData>();
        public Dictionary<int, HeroData> MakeDict()
        {
            Dictionary<int, HeroData> dict = new Dictionary<int, HeroData>();
            foreach (HeroData info in hero)
                dict.Add(info.DataId, info);
            return dict;
        }
    }
    #endregion

    #region EnemyData
    [Serializable]
    public class EnemyData : CreatureData { }

    [Serializable]
    public class EnemyDataLoader : ILoader<int, EnemyData>
    {
        public List<EnemyData> hero = new List<EnemyData>();
        public Dictionary<int, EnemyData> MakeDict()
        {
            Dictionary<int, EnemyData> dict = new Dictionary<int, EnemyData>();
            foreach (EnemyData info in hero)
                dict.Add(info.DataId, info);
            return dict;
        }
    }
    #endregion

    #region EquipmentInfoData
    [Serializable]
    public class EquipmentData
    {
        public int DataId;
        public string Name;
        public string Description;
        public float Attack;
        public float Defence;
        public float SkillDamage;
        public string Type;
        public string Grade;
    }

    [Serializable]
    public class EquipmentDataLoader : ILoader<int, EquipmentData>
    {
        public List<EquipmentData> equipment = new List<EquipmentData>();
        public Dictionary<int, EquipmentData> MakeDict()
        {
            Dictionary<int, EquipmentData> dict = new Dictionary<int, EquipmentData>();
            foreach (EquipmentData info in equipment)
                dict.Add(info.DataId, info);
            return dict;
        }
    }
    #endregion

    #region SkillData
    [Serializable]
    public class SkillData
    {
        public int DataId;
        public string Name;
        public string Description;
        public float SkillDamage;
        public string Type;
    }
    #endregion

    #region DefaultSkillData
    [Serializable]
    public class DefaultSkillData : SkillData { }

    [Serializable]
    public class DefaultSkillDataLoader : ILoader<int, DefaultSkillData>
    {
        public List<DefaultSkillData> defaultSkillInfo = new List<DefaultSkillData>();
        public Dictionary<int, DefaultSkillData> MakeDict()
        {
            Dictionary<int, DefaultSkillData> dict = new Dictionary<int, DefaultSkillData>();
            foreach (DefaultSkillData info in defaultSkillInfo)
                dict.Add(info.DataId, info);
            return dict;
        }
    }
    #endregion

    #region SkillAData
    [Serializable]
    public class SkillAData : SkillData { }

    [Serializable]
    public class SkillADataLoader : ILoader<int, SkillAData>
    {
        public List<SkillAData> skillAInfo = new List<SkillAData>();
        public Dictionary<int, SkillAData> MakeDict()
        {
            Dictionary<int, SkillAData> dict = new Dictionary<int, SkillAData>();
            foreach (SkillAData info in skillAInfo)
                dict.Add(info.DataId, info);
            return dict;
        }
    }
    #endregion

    #region SkillBData
    [Serializable]
    public class SkillBData : SkillData { }

    [Serializable]
    public class SkillBDataLoader : ILoader<int, SkillBData>
    {
        public List<SkillBData> skillAInfo = new List<SkillBData>();
        public Dictionary<int, SkillBData> MakeDict()
        {
            Dictionary<int, SkillBData> dict = new Dictionary<int, SkillBData>();
            foreach (SkillBData info in skillAInfo)
                dict.Add(info.DataId, info);
            return dict;
        }
    }
    #endregion

    #region LevelMaterialData
    [Serializable]
    public class LevelMaterialData
    {
        public int DataId;
        public string Name;
        public string Description;
        public float Exp;
    }

    [Serializable]
    public class LevelMaterialDataLoader : ILoader<int, LevelMaterialData>
    {
        public List<LevelMaterialData> skillAInfo = new List<LevelMaterialData>();
        public Dictionary<int, LevelMaterialData> MakeDict()
        {
            Dictionary<int, LevelMaterialData> dict = new Dictionary<int, LevelMaterialData>();
            foreach (LevelMaterialData info in skillAInfo)
                dict.Add(info.DataId, info);
            return dict;
        }
    }
    #endregion
}