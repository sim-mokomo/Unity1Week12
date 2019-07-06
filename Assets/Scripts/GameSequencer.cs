using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSequencer : MonoBehaviour
{
    [SerializeField] private UIBossPreviewWarningWindow _uiBossPreviewWarningWindow;
    [SerializeField] private WaveSequencer _waveSequencer;

    private void Start()
    {
        var wave = _waveSequencer.FetchCurrentWave();
        _uiBossPreviewWarningWindow.ApplyBossConfig(wave.BossConfig);
        _waveSequencer.MoveNextWave();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var wave = _waveSequencer.FetchCurrentWave();
            _uiBossPreviewWarningWindow.ApplyBossConfig(wave.BossConfig);
            _waveSequencer.MoveNextWave();            
        }
    }
}
