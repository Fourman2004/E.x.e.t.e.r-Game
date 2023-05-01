using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMent : MonoBehaviour
{
    public GameObject Playbutton, QuitButton;
    private void Start()
    {
        Cursor.visible = true;
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void BackToStart()
    {
        SceneManager.LoadScene("GameStart");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
