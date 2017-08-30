using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {
	public GameObject player; 
	// Use this for initialization


	public void activate (Vector3 pos) {
		switch(this.gameObject.name)
		{
			case "Wave":
				waveAttack();
				break;
			case "Burst":
				burstAttack(pos);
				break;
		}

	}
	
	void waveAttack () {
		Debug.Log("Wave!!");
	}

	void burstAttack (Vector3 pos) {
		GameObject shot = Instantiate(this.gameObject, pos, Quaternion.identity);
		Debug.Log(shot.GetComponent<CircleCollider2D>().bounds);
	}
}
