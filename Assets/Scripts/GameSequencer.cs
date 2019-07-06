using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameSequence
{
    None,
    BossPreview,
    BossBattle,
    Shop,
}

public class GameSequencer : MonoBehaviour
{
    [SerializeField] private UIBossPreviewWarningWindow _uiBossPreviewWarningWindow;
    [SerializeField] private UIShopWindow _uiShopWindow;
    [SerializeField] private UIBossBattleWindow _uiBossBattleWindow;
    [SerializeField] private WaveSequencer _waveSequencer;

    [Header("Debug")]
    [SerializeField] private GameSequence _initDebugSequence;

    private void Start()
    {
        UpdateUIActivate( _initDebugSequence == GameSequence.None ? GameSequence.BossPreview : _initDebugSequence );
        _uiBossPreviewWarningWindow.ApplyBossConfig(_waveSequencer.FetchCurrentWave().BossConfig);

        _uiBossPreviewWarningWindow.OnNextSequence += () =>
        {
            UpdateUIActivate(GameSequence.Shop);
        };

        _uiShopWindow.OnNextSequence += () =>
        {
            UpdateUIActivate(GameSequence.BossPreview);
            _waveSequencer.MoveNextWave();
            _uiBossPreviewWarningWindow.ApplyBossConfig(_waveSequencer.FetchCurrentWave().BossConfig);   
        };
    }

    private void UpdateUIActivate(GameSequence gameSequence)
    {
        switch (gameSequence)
        {
                case GameSequence.BossPreview :
                    _uiBossPreviewWarningWindow.gameObject.SetActive(true);
                    _uiBossBattleWindow.gameObject.SetActive(false);
                    _uiShopWindow.gameObject.SetActive(false);
                    break;
                case GameSequence.BossBattle:
                    _uiBossPreviewWarningWindow.gameObject.SetActive(false);
                    _uiBossBattleWindow.gameObject.SetActive(true);
                    _uiShopWindow.gameObject.SetActive(false);
                    break;
                case GameSequence.Shop:
                    _uiBossPreviewWarningWindow.gameObject.SetActive(false);
                    _uiBossBattleWindow.gameObject.SetActive(false);
                    _uiShopWindow.gameObject.SetActive(true);
                    break;
        }
    }
}
