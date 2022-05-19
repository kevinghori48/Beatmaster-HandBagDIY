using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEditor;
using UnityEngine;

public class SceneLoaderEditor : MonoBehaviour
{
    [MenuItem("Scene/MainScene")]
    public static void LoadMainScene()
    {
        EditorSceneManager.OpenScene("Assets/_Game/Scenes/MainScene.unity");
    }
    
    [MenuItem("Scene/Sticker Maker")]
    public static void LoadStickerMakerScene()
    {
        EditorSceneManager.OpenScene("Assets/_Game/Scenes/StickerMaker.unity");
    }
}
