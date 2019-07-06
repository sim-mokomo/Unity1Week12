using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BossConfigEditor : MonoBehaviour
{
    private static readonly string basePathForCreating = "Assets/Configs";
    
    [MenuItem("Unity1Week12/ボスの設定データ作成")]
    static void CreateAssetInstance ()
    {
        var configAsset = ScriptableObject.CreateInstance<BossConfig>();
        AssetDatabase.CreateAsset (configAsset,  $"{basePathForCreating}/ExampleAsset.asset");
        AssetDatabase.Refresh ();
    }
}
