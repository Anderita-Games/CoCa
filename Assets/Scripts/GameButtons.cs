using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class GameButtons : MonoBehaviour
{
    public bool paused;
    public GameObject Tpaused;
    public virtual void update()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public virtual void restart()
    {
        Application.LoadLevel(Application.loadedLevelName);
    }

    public virtual void pause()
    {
        if (PlayerPrefs.GetInt("paused") == 1)
        {
            Debug.Log("Pausing...");
            PlayerPrefs.SetInt("paused", 0);
            Time.timeScale = PlayerPrefs.GetInt("paused");
            this.Tpaused.SetActive(true);
        }
        else
        {
            if (PlayerPrefs.GetInt("paused") == 0)
            {
                Debug.Log("Pausing...");
                PlayerPrefs.SetInt("paused", 1);
                Time.timeScale = PlayerPrefs.GetInt("paused");
                this.Tpaused.SetActive(false);
            }
        }
    }

    public virtual void MainMenu()
    {
        Application.LoadLevel("MainMenu");
        this.paused = false;
        Time.timeScale = 1;
    }

}