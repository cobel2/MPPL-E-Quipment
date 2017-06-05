using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayScene : MonoBehaviour
{
    public LoadSceneMode loadMode = LoadSceneMode.Additive;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, loadMode);
    }
}