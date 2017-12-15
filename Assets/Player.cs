using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Variable
    public int vie, degats;
    public Ennemie ennemie;
	public bool bouclier=false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		var armePlayer = GameObject.FindWithTag("armePlayer");
		var bouclierPlayer = GameObject.FindWithTag("bouclierPlayer");

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			armePlayer.transform.RotateAround (Vector3.zero, Vector3.down, 5 * Time.deltaTime);
		} else {
			armePlayer.transform.RotateAround (Vector3.zero, Vector3.up, 5 * Time.deltaTime);
		}
		if (Input.GetKeyDown (KeyCode.Mouse1)) {
			bouclier = true;
			bouclierPlayer.transform.RotateAround (Vector3.zero, Vector3.right, 5 * Time.deltaTime);
		} else {
			bouclierPlayer.transform.RotateAround (Vector3.zero, Vector3.left, 5 * Time.deltaTime);
		}
		bouclier = false;

		//Respawn
		if(vie==0){
			if (gameObject.tag == "Player") {
				gameObject.transform.position = GameObject.Find ("SpawnPoint").transform.position;
				vie = 50;
			}
		}
	}
		
    void OnTriggerEnter(Collider c)
	{
		if (bouclier == true) {
		} else {
			var armeEnnemie = GameObject.FindGameObjectsWithTag ("armeEnnemie");
			var degatEnnemie = ennemie.degats;
			vie = vie - degatEnnemie;
		}
	}
}
