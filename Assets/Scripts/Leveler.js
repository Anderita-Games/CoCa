#pragma strict
public var Reverse1 : GameObject;

function Start () {
	if (PlayerPrefs.GetInt("DoneLevel5") == 0) {
		Reverse1.SetActive(false);
	}
}

function Update () {

}