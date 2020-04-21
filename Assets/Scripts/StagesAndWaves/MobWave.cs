﻿using UnityEngine;
using System;
using Sirenix.Serialization;
using GameData;
using System.Collections.Generic;

[Serializable]
public struct MobWave
{

    [Serializable]
    public struct Mob
    {
        [OdinSerialize] public MonsterData monsterData;
        [OdinSerialize] public GameObject monsterPrefab;
        [OdinSerialize] public int count;
    }

    [OdinSerialize] public List<Mob> MobsInTheWave;

    [OdinSerialize] public float DelayInBetween;
    [OdinSerialize] public float DelayAfterWave;
}
