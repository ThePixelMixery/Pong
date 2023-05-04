using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlButtons : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0,LoadSceneMode.Single);
    }

    public void PlayBase()
    {
        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
