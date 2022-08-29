using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiControl : MonoBehaviour
{
    // Start is called before the first frame update
    public void MainLagi()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
    public void Mulai()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }
}
