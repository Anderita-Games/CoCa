using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Shaders : MonoBehaviour
{
    public int i;
    public static int zero; //   <------ Very complicated var most computers cant handle its power! :D
    public virtual void Start()
    {
        this.i = Application.loadedLevel;
        PlayerPrefs.SetInt("savedLevel", this.i);
    }

    public virtual void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            PlayerPrefs.SetInt("savedLevel", this.i + 1);
            PlayerPrefs.SetInt("Done" + Application.loadedLevelName, 1); // Completed level
            //Setting highscore
            if (Time.timeSinceLevelLoad <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
            {
                PlayerPrefs.SetInt("Best" + Application.loadedLevelName, (int) Time.timeSinceLevelLoad);
            }
            else
            {
                //saving playerPrefs
                if (Shaders.zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName))
                {
                    PlayerPrefs.SetInt("Best" + Application.loadedLevelName, (int) Time.timeSinceLevelLoad);
                }
            }
            //saving playerPrefs
            //Level loading sturf
            if ((Application.loadedLevelName == "Level5") || (Application.loadedLevelName == "RLevel5"))
            {
                Application.LoadLevel("LevelSelect");
                PlayerPrefs.SetInt("savedLevel", this.i);
            }
            else
            {
                Application.LoadLevel(this.i + 1);
            }
            Debug.Log("Done" + this.i);
        }
    }

}