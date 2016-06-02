#pragma strict
var sphere : GameObject;
var spherePos : Vector3;

function Start () {
	
}

function Update () {
	sphere = GameObject.Find("Sphere");
	transform.position.y = sphere.transform.position.y;
	transform.position.x = sphere.transform.position.x;
}

function OnCollisionEnter (col : Collision){
	if (col.gameObject.name == "Sphere") {
		
	}else if(PlayerPrefs.GetFloat("Swing") == 4.0) {
		PlayerPrefs.SetFloat("Swing", -4.0);
	}else if(PlayerPrefs.GetFloat("Swing") == -4.0) {
		PlayerPrefs.SetFloat("Swing", 4.0);
	}
	
	if (col.gameObject.name == "Sphere") {
		
	}else {
		PlayerPrefs.SetFloat("isFalling", 2);
	}
}
