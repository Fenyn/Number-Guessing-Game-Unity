using UnityEngine;
using UnityEditor.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string name)
    {
        EditorSceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Application.Quit();
    }
}