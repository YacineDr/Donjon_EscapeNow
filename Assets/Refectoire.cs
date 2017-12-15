using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refectoire : MonoBehaviour {

	public Player player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerExit(Collider c){

		player.vie = player.vie + 50;
	}
}
