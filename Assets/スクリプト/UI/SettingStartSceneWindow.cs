
#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement; // ← 追加

public class SettingStartSceneWindow : EditorWindow
{
    [MenuItem("Window/Start Scene Settings")]
    public static void ShowWindow()
    {
        GetWindow<SettingStartSceneWindow>("Start Scene Settings");
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Set Start Scene"))
        {
            // 正しい SceneManagement の使用
            EditorSceneManager.OpenScene("Assets/Scenes/StartScene.unity");
        }
    }
}
#endif
