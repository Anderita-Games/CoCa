#pragma strict
var i : int; 
i = Application.loadedLevel;
static var zero : int = 0; //   <------ Very complicated var most computers cant handle its power! :D

function Start () {
	PlayerPrefs.SetInt("savedLevel", i);
}


function OnCollisionEnter(col : Collision) {
	
	if (col.gameObject.name == "Sphere") {
		PlayerPrefs.SetInt("savedLevel", i + 1);
		PlayerPrefs.SetInt("Done" + Application.loadedLevelName, 1); // Completed level
		//Setting highscore
		if(Time.timeSinceLevelLoad <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) {
			PlayerPrefs.SetInt("Best" + Application.loadedLevelName, Time.timeSinceLevelLoad);
			//saving playerPrefs
		} else if(zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)) {
			PlayerPrefs.SetInt("Best" + Application.loadedLevelName, Time.timeSinceLevelLoad);
			//saving playerPrefs
		}
	
	
		//Level loading sturf
		if (Application.loadedLevelName == "Level5" || Application.loadedLevelName == "RLevel5") {
			Application.LoadLevel("LevelSelect"); 
			PlayerPrefs.SetInt("savedLevel", i);
		} else {
			Application.LoadLevel(i + 1);
		}
	
		Debug.Log("Done" + i);
	}
}
	