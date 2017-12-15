using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemie : MonoBehaviour {

	public int vie, degats;
	public Player player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		{
		var armeEnnemie = GameObject.FindWithTag("armeEnnemie");
		armeEnnemie.transform.RotateAround (Vector3.zero, Vector3.down, 5 * Time.deltaTime);
		armeEnnemie.transform.RotateAround (Vector3.zero, Vector2.up, 5 * Time.deltaTime);
		}
	}

	//Si le joueur rencontre l'ennemie
	void OnTriggerEnter(Collider c){
			var armePlayer = GameObject.FindGameObjectsWithTag ("armePlayer");
			var degatPlayer = player.degats;
			vie = vie - degatPlayer;
	}

}
