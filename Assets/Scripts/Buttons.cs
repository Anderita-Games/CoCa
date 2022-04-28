using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Buttons : MonoBehaviour
{
    //Suggestive text >:)
    public GameObject Cant;
    public GameObject RedCant;
    public GameObject Cant2;
    public GameObject Cant3;
    public GameObject Cant4;
    public GameObject Cant5;
    public GameObject Cant6;
    public GameObject Cant7;
    //Buttons
    public GameObject levels5;
    public GameObject levels4;
    public GameObject levels3;
    public GameObject levels2;
    //Blockers
    public GameObject Blocker2;
    public GameObject Blocker3;
    public GameObject Blocker4;
    public GameObject Blocker5;
    public int Scream;
    public virtual void Start()
    {
        if (Application.loadedLevelName == "Level")
        {
            if (PlayerPrefs.GetInt("DoneLevel1") == 0)
            {
                this.Blocker2.SetActive(true);
                this.Blocker3.SetActive(true);
                this.Blocker4.SetActive(true);
                this.Blocker5.SetActive(true);
            }
            else
            {
                if (PlayerPrefs.GetInt("DoneLevel2") == 0)
                {
                    this.Blocker3.SetActive(true);
                    this.Blocker4.SetActive(true);
                    this.Blocker5.SetActive(true);
                }
                else
                {
                    if (PlayerPrefs.GetInt("DoneLevel3") == 0)
                    {
                        this.Blocker4.SetActive(true);
                        this.Blocker5.SetActive(true);
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("DoneLevel4") == 0)
                        {
                            this.Blocker5.SetActive(true);
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("DoneLevel5") == 0)
                            {
                            }
                        }
                    }
                }
            }
        }
        else
        {
            //nothing shall pass
            if (Application.loadedLevelName == "RLevel") //Reversed Level pack 1
            {
                if (PlayerPrefs.GetInt("DoneRLevel1") == 0)
                {
                    this.Blocker2.SetActive(true);
                    this.Blocker3.SetActive(true);
                    this.Blocker4.SetActive(true);
                    this.Blocker5.SetActive(true);
                }
                else
                {
                    if (PlayerPrefs.GetInt("DoneRLevel2") == 0)
                    {
                        this.Blocker3.SetActive(true);
                        this.Blocker4.SetActive(true);
                        this.Blocker5.SetActive(true);
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("DoneRLevel3") == 0)
                        {
                            this.Blocker4.SetActive(true);
                            this.Blocker5.SetActive(true);
                        }
                        else
                        {
                            if (PlayerPrefs.GetInt("DoneRLevel4") == 0)
                            {
                                this.Blocker5.SetActive(true);
                            }
                        }
                    }
                }
            }
        }
    }

    public virtual void update()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public virtual void QuitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }

    public virtual void MainMenu()
    {
        Application.LoadLevel("MainMenu");
        Time.timeScale = 1;
    }

    public virtual void Playgame()
    {
        if (PlayerPrefs.HasKey("savedLevel"))
        {
            // there is a saved Level, load that one
            Application.LoadLevel(PlayerPrefs.GetInt("savedLevel"));
        }
        else
        {
            // no saved Level, load the first one
            Application.LoadLevel("Level1");
        }
    }

    public virtual void Tutorial()
    {
        Application.LoadLevel("Tutorial");
    }

    //All the scene selection stuff
    public virtual void levelselectoor()
    {
        Application.LoadLevel("LevelSelect");
    }

    public virtual void levels()
    {
        Application.LoadLevel("Level");
    }

    public virtual void levelsR()
    {
        Application.LoadLevel("RLevel");
    }

    //Level Pack 1
    public virtual void Level1()
    {
        Application.LoadLevel("Level1");
    }

    public virtual void Level2()
    {
        if (PlayerPrefs.GetInt("DoneLevel1") == 1)
        {
            Application.LoadLevel("Level2");
        }
        else
        {
            this.StartCoroutine(this.Warning());
        }
    }

    public virtual void Level3()
    {
        if (PlayerPrefs.GetInt("DoneLevel2") == 1)
        {
            Application.LoadLevel("Level3");
        }
        else
        {
            this.StartCoroutine(this.Warning());
        }
    }

    public virtual void Level4()
    {
        if (PlayerPrefs.GetInt("DoneLevel3") == 1)
        {
            Application.LoadLevel("Level4");
        }
        else
        {
            this.StartCoroutine(this.Warning());
        }
    }

    public virtual void Level5()
    {
        if (PlayerPrefs.GetInt("DoneLevel4") == 1)
        {
            Application.LoadLevel("Level5");
        }
        else
        {
            this.StartCoroutine(this.Warning());
        }
    }

    //Reverse Level pack
    public virtual void RLevel1()
    {
        Application.LoadLevel("RLevel1");
    }

    public virtual void RLevel2()
    {
        if (PlayerPrefs.GetInt("RLevel1") == 1)
        {
            Application.LoadLevel("RLevel2");
        }
        else
        {
            this.StartCoroutine(this.Warning());
        }
    }

    public virtual void RLevel3()
    {
        if (PlayerPrefs.GetInt("RLevel2") == 1)
        {
            Application.LoadLevel("RLevel3");
        }
        else
        {
            this.StartCoroutine(this.Warning());
        }
    }

    public virtual void RLevel4()
    {
        if (PlayerPrefs.GetInt("RLevel3") == 1)
        {
            Application.LoadLevel("RLevel4");
        }
        else
        {
            this.StartCoroutine(this.Warning());
        }
    }

    public virtual void RLevel5()
    {
        if (PlayerPrefs.GetInt("RLevel5") == 1)
        {
            Application.LoadLevel("RLevel5");
        }
        else
        {
            this.StartCoroutine(this.Warning());
        }
    }

    public virtual IEnumerator Warning()
    {
        this.Scream = this.Scream + 1;
        if (this.Scream == 1)
        {
            this.Cant.SetActive(true);
        }
        else
        {
            if (this.Scream == 2)
            {
                this.Cant.SetActive(false);
                this.RedCant.SetActive(true);
            }
            else
            {
                if (this.Scream == 3)
                {
                    this.RedCant.SetActive(false);
                    yield return new WaitForSeconds(0.5f);
                    this.RedCant.SetActive(true);
                }
                else
                {
                    if (this.Scream == 4)
                    {
                        this.Cant2.SetActive(true);
                    }
                    else
                    {
                        if (this.Scream == 5)
                        {
                            this.Cant3.SetActive(true); //ugh
                        }
                        else
                        {
                            if (this.Scream == 6)
                            {
                                this.Cant4.SetActive(true); //making me mad
                            }
                            else
                            {
                                if (this.Scream == 7)
                                {
                                    this.Cant5.SetActive(true); //your asking for it
                                }
                                else
                                {
                                    if (this.Scream == 8)
                                    {
                                        this.Cant5.SetActive(false);
                                        this.Cant4.SetActive(false);
                                        this.Cant3.SetActive(false);
                                        this.Cant2.SetActive(false);
                                        this.RedCant.SetActive(false);
                                        this.Cant6.SetActive(true); //one more time
                                    }
                                    else
                                    {
                                        if (this.Scream == 9)
                                        {
                                            //NUCLEAR
                                            if (PlayerPrefs.GetInt("DoneLevel1") == 0)
                                            {
                                                this.levels5.SetActive(false);
                                                this.levels4.SetActive(false);
                                                this.levels3.SetActive(false);
                                                this.levels2.SetActive(false);
                                            }
                                            else
                                            {
                                                if (PlayerPrefs.GetInt("DoneLevel2") == 0)
                                                {
                                                    this.levels5.SetActive(false);
                                                    this.levels4.SetActive(false);
                                                    this.levels3.SetActive(false);
                                                }
                                                else
                                                {
                                                    if (PlayerPrefs.GetInt("DoneLevel3") == 0)
                                                    {
                                                        this.levels5.SetActive(false);
                                                        this.levels4.SetActive(false);
                                                    }
                                                    else
                                                    {
                                                        if (PlayerPrefs.GetInt("DoneLevel4") == 0)
                                                        {
                                                            this.levels5.SetActive(false);
                                                        }
                                                        else
                                                        {
                                                            if (PlayerPrefs.GetInt("DoneRLevel1") == 0) //Reversed Level Pack 1
                                                            {
                                                                this.levels5.SetActive(false);
                                                                this.levels4.SetActive(false);
                                                                this.levels3.SetActive(false);
                                                                this.levels2.SetActive(false);
                                                            }
                                                            else
                                                            {
                                                                if (PlayerPrefs.GetInt("DoneRLevel2") == 0)
                                                                {
                                                                    this.levels5.SetActive(false);
                                                                    this.levels4.SetActive(false);
                                                                    this.levels3.SetActive(false);
                                                                }
                                                                else
                                                                {
                                                                    if (PlayerPrefs.GetInt("DoneRLevel3") == 0)
                                                                    {
                                                                        this.levels5.SetActive(false);
                                                                        this.levels4.SetActive(false);
                                                                    }
                                                                    else
                                                                    {
                                                                        if (PlayerPrefs.GetInt("DoneRLevel4") == 0)
                                                                        {
                                                                            this.levels5.SetActive(false);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            this.Cant6.SetActive(false);
                                            this.Cant7.SetActive(true);
                                            this.Blocker5.SetActive(false);
                                            this.Blocker4.SetActive(false);
                                            this.Blocker3.SetActive(false);
                                            this.Blocker2.SetActive(false);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}