#pragma strict
var paused : boolean = false;
public var Tpaused : GameObject;

function update () {
	Screen.sleepTimeout = SleepTimeout.NeverSleep;
}

function restart() {
	Application.LoadLevel(Application.loadedLevelName);
}

function pause(){
	 if (PlayerPrefs.GetInt("paused") == 1)
        {
        	Debug.Log ("Pausing...");
            PlayerPrefs.SetInt("paused", 0);
            Time.timeScale = PlayerPrefs.GetInt("paused");
            Tpaused.SetActive (true);
        }
     else if (PlayerPrefs.GetInt("paused") == 0)
        {
        	Debug.Log ("Pausing...");
            PlayerPrefs.SetInt("paused", 1);
            Time.timeScale = PlayerPrefs.GetInt("paused");
            Tpaused.SetActive (false);
        }
}

function MainMenu()
{
	Application.LoadLevel("MainMenu");
	paused = false;
	Time.timeScale = 1;
}