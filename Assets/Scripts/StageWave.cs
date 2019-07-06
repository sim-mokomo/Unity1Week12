using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StageWave
{
    [SerializeField] private BossConfig _bossConfig;
    public BossConfig BossConfig => _bossConfig;
}
