#pragma strict
//Suggestive text >:)
public var Cant : GameObject;
public var RedCant : GameObject;
public var Cant2 : GameObject;
public var Cant3 : GameObject;
public var Cant4 : GameObject;
public var Cant5 : GameObject;
public var Cant6 : GameObject;
public var Cant7 : GameObject;
//Buttons
public var levels5 : GameObject;
public var levels4 : GameObject;
public var levels3 : GameObject;
public var levels2 : GameObject;
//Blockers
public var Blocker2 : GameObject;
public var Blocker3 : GameObject;
public var Blocker4 : GameObject;
public var Blocker5 : GameObject;
var Scream : int;

function Start () {
	if (Application.loadedLevelName == "Level") {
		if (PlayerPrefs.GetInt("DoneLevel1") == 0) {
			Blocker2.SetActive(true);
			Blocker3.SetActive(true);
			Blocker4.SetActive(true);
			Blocker5.SetActive(true);
		}else if (PlayerPrefs.GetInt("DoneLevel2") == 0) {
			Blocker3.SetActive(true);
			Blocker4.SetActive(true);
			Blocker5.SetActive(true);
		}else if (PlayerPrefs.GetInt("DoneLevel3") == 0) {
			Blocker4.SetActive(true);
			Blocker5.SetActive(true);
		}else if (PlayerPrefs.GetInt("DoneLevel4") == 0) {
			Blocker5.SetActive(true);
		}else if (PlayerPrefs.GetInt("DoneLevel5") == 0) {
			//nothing shall pass
		}
	}else if (Application.loadedLevelName == "RLevel") {		//Reversed Level pack 1
		if (PlayerPrefs.GetInt("DoneRLevel1") == 0) { 
			Blocker2.SetActive(true);
			Blocker3.SetActive(true);
			Blocker4.SetActive(true);
			Blocker5.SetActive(true);
		}else if (PlayerPrefs.GetInt("DoneRLevel2") == 0) {
			Blocker3.SetActive(true);
			Blocker4.SetActive(true);
			Blocker5.SetActive(true);
		}else if (PlayerPrefs.GetInt("DoneRLevel3") == 0) {
			Blocker4.SetActive(true);
			Blocker5.SetActive(true);
		}else if (PlayerPrefs.GetInt("DoneRLevel4") == 0) {
			Blocker5.SetActive(true);
		}
	}
	
}

function update () {
	Screen.sleepTimeout = SleepTimeout.NeverSleep;
}

function QuitGame ()  {
	Debug.Log ("Game is exiting...");
	Application.Quit ();
}

function MainMenu() {
	Application.LoadLevel("MainMenu");
	Time.timeScale = 1;
}

function Playgame() {
	if(PlayerPrefs.HasKey("savedLevel")){
   		// there is a saved Level, load that one
   		Application.LoadLevel(PlayerPrefs.GetInt("savedLevel"));
	} else{
   		// no saved Level, load the first one
   		Application.LoadLevel("Level1");
 	}
}

function Tutorial() {
	Application.LoadLevel("Tutorial");
}

//All the scene selection stuff
function levelselectoor() {
	Application.LoadLevel("LevelSelect");
}
function levels() {
	Application.LoadLevel("Level");
}
function levelsR() {
	Application.LoadLevel("RLevel");
}

//Level Pack 1
function Level1() {
	Application.LoadLevel("Level1");
}
function Level2() {
	if (PlayerPrefs.GetInt("DoneLevel1") == 1) {
		Application.LoadLevel("Level2");
	}else {
		Warning();
	}
}
function Level3() {
	if (PlayerPrefs.GetInt("DoneLevel2") == 1) {
		Application.LoadLevel("Level3");
	}else {
		Warning();
	}
}
function Level4() {
	if (PlayerPrefs.GetInt("DoneLevel3") == 1) {
		Application.LoadLevel("Level4");
	}else {
		Warning();
	}
}
function Level5() {
	if (PlayerPrefs.GetInt("DoneLevel4") == 1) {
		Application.LoadLevel("Level5");
	}else {
		Warning();
	}
}
//Reverse Level pack
function RLevel1() {
	Application.LoadLevel("RLevel1");
}
function RLevel2() {
	if (PlayerPrefs.GetInt("RLevel1") == 1) {
		Application.LoadLevel("RLevel2");
	}else {
		Warning();
	}
}
function RLevel3() {
	if (PlayerPrefs.GetInt("RLevel2") == 1) {
		Application.LoadLevel("RLevel3");
	}else {
		Warning();
	}
}
function RLevel4() {
	if (PlayerPrefs.GetInt("RLevel3") == 1) {
		Application.LoadLevel("RLevel4");
	}else {
		Warning();
	}
}
function RLevel5() {
	if (PlayerPrefs.GetInt("RLevel5") == 1) {
		Application.LoadLevel("RLevel5");
	}else {
		Warning();
	}
}


function Warning() {
	Scream += 1;
	if (Scream == 1) {
		Cant.SetActive (true);
	}else if (Scream == 2) {
		Cant.SetActive (false);
		RedCant.SetActive (true);
	}else if (Scream == 3) {
		RedCant.SetActive (false);
		yield WaitForSeconds (.5);
		RedCant.SetActive (true);
	}else if (Scream == 4) {
		Cant2.SetActive(true);
	}else if (Scream == 5) {
		Cant3.SetActive(true); //ugh
	}else if (Scream == 6) {
		Cant4.SetActive(true); //making me mad
	}else if (Scream == 7) {
		Cant5.SetActive(true); //your asking for it
	}else if (Scream == 8) {
		Cant5.SetActive(false);
		Cant4.SetActive(false);
		Cant3.SetActive(false);
		Cant2.SetActive(false);
		RedCant.SetActive(false);
		Cant6.SetActive(true); //one more time
	}else if (Scream == 9) {
		//NUCLEAR
		if (PlayerPrefs.GetInt("DoneLevel1") == 0) {
			levels5.SetActive(false);
			levels4.SetActive(false);
			levels3.SetActive(false);
			levels2.SetActive(false);
		}else if (PlayerPrefs.GetInt("DoneLevel2") == 0) {
			levels5.SetActive(false);
			levels4.SetActive(false);
			levels3.SetActive(false);
		}else if (PlayerPrefs.GetInt("DoneLevel3") == 0) {
			levels5.SetActive(false);
			levels4.SetActive(false);
		}else if (PlayerPrefs.GetInt("DoneLevel4") == 0) {
			levels5.SetActive(false);
		}else if (PlayerPrefs.GetInt("DoneRLevel1") == 0) { //Reversed Level Pack 1
			levels5.SetActive(false);
			levels4.SetActive(false);
			levels3.SetActive(false);
			levels2.SetActive(false);
		}else if (PlayerPrefs.GetInt("DoneRLevel2") == 0) {
			levels5.SetActive(false);
			levels4.SetActive(false);
			levels3.SetActive(false);
		}else if (PlayerPrefs.GetInt("DoneRLevel3") == 0) {
			levels5.SetActive(false);
			levels4.SetActive(false);
		}else if (PlayerPrefs.GetInt("DoneRLevel4") == 0) {
			levels5.SetActive(false);
		}
		Cant6.SetActive(false);
		Cant7.SetActive(true);
		Blocker5.SetActive(false);
		Blocker4.SetActive(false);
		Blocker3.SetActive(false);
		Blocker2.SetActive(false);
	}
}
