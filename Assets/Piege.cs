using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piege : MonoBehaviour {

	public int degatspiege;
	public bool piege = false;
	public Player player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter(Collider c){
		piege = true;
		player.vie = player.vie - degatspiege;
	}
}
