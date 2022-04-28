#pragma strict

static var TextWidth : int = Screen.width/4;
public static var savedLevel : String;
var CTime : UnityEngine.UI.Text;
var HTime : UnityEngine.UI.Text;
static var zero : int = 0;

function Start () {
	Debug.Log (Application.loadedLevelName);
	PlayerPrefs.SetInt("paused", 1);
	Time.timeScale = PlayerPrefs.GetInt("paused");
}

function Update () {
	//time text
	CTime.text = "Current Time: " + Time.timeSinceLevelLoad;
	if(zero >= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) {
		HTime.text = "No best time!!!";
	} else if(zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) {
		HTime.text = "Best Time: " + PlayerPrefs.GetInt("Best" + Application.loadedLevelName) + " seconds";
	}
	
	Time.timeScale = PlayerPrefs.GetInt("paused"); // Set pause or naw
}