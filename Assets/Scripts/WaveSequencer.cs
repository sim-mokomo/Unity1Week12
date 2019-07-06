using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSequencer : MonoBehaviour
{
    [SerializeField] private List<StageWave> _stageWaves;
    private int _currentWaveIndex = 0;

    public void Initialize()
    {
        _currentWaveIndex = 0;
    }
    
    public StageWave FetchCurrentWave()
    {
        return _stageWaves[_currentWaveIndex];
    }

    public void MoveNextWave()
    {
        _currentWaveIndex = (_currentWaveIndex + 1) % _stageWaves.Count;
    }
}
