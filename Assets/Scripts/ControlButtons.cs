using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlButtons : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex:0,LoadSceneMode.Single);
    }

    public void PlayBase()
    {
        SceneManager.LoadScene(sceneBuildIndex:1,LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
