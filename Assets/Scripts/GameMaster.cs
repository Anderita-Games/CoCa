using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class GameMaster : MonoBehaviour
{
    public static int TextWidth;
    public static string savedLevel;
    public UnityEngine.UI.Text CTime;
    public UnityEngine.UI.Text HTime;
    public static int zero;
    public virtual void Start()
    {
        Debug.Log(Application.loadedLevelName);
        PlayerPrefs.SetInt("paused", 1);
        Time.timeScale = PlayerPrefs.GetInt("paused");
    }

    public virtual void Update()
    {
        //time text
        this.CTime.text = "Current Time: " + Time.timeSinceLevelLoad;
        if (GameMaster.zero >= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
        {
            this.HTime.text = "No best time!!!";
        }
        else
        {
            if (GameMaster.zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
            {
                this.HTime.text = ("Best Time: " + PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) + " seconds";
            }
        }
        Time.timeScale = PlayerPrefs.GetInt("paused"); // Set pause or naw
    }

    static GameMaster()
    {
        GameMaster.TextWidth = Screen.width / 4;
    }

}