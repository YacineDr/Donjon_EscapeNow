using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infirmerie : MonoBehaviour {

	public Player player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void onTriggerExit(Collider c){

		player.degats = player.degats + 5;
		player.vie = player.vie + 25;
	}
}
