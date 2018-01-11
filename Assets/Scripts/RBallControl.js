#pragma strict
var jumpHeight = 10;
var Jump:AudioClip;
private var isFalling = false;
var gravity : float = -20.0;
var R : GameObject;
var L : GameObject;
var bruh;
var bruh2;

function Start () {
	PlayerPrefs.SetFloat("Swing", -4.0);
	PlayerPrefs.SetFloat("isFalling", 0);
}

function Update () {
	
	GetComponent.<Rigidbody>().velocity.x = PlayerPrefs.GetFloat("Swing");
	GetComponent.<Rigidbody>().velocity.y -= gravity * Time.deltaTime;
	
	Time.timeScale = PlayerPrefs.GetInt("paused");
	

	if ((Input.GetKey ("up") || Input.GetMouseButtonDown(0)) && PlayerPrefs.GetFloat("isFalling") > 0){
		GetComponent.<Rigidbody>().velocity.y = -5;
		PlayerPrefs.SetFloat("isFalling", PlayerPrefs.GetFloat("isFalling") - 1);
	}
	
}

function OnCollisionStay (col : Collision){
	if (col.gameObject.name == "R" || col.gameObject.name == "L") {
		
	}else {
		PlayerPrefs.SetFloat("isFalling", 1);
	}
	
	bruh = GetComponent.<Rigidbody>().position.x;
	if (bruh == bruh2) {
		if(PlayerPrefs.GetFloat("Swing") == 4.0) {
			PlayerPrefs.SetFloat("Swing", -4.0);
		}else if(PlayerPrefs.GetFloat("Swing") == -4.0) {
			PlayerPrefs.SetFloat("Swing", 4.0);
		}
	}
	yield WaitForSeconds (.01);
	bruh2 = bruh;
}
