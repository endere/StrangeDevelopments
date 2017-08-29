using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class follow : MonoBehaviour {
	// public GameObject target;
	public float speed;
	private Vector3 target;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		target = GameObject.Find("Player").transform.position;
		Vector3 toTarget = target - transform.position;
		float mod = Math.Abs(toTarget[0]) + Math.Abs(toTarget[1]);
		transform.Translate(toTarget * (speed/mod) * Time.deltaTime);
		//to have them slow down as they approach the player, instead of travel
		//at a constant speed. take out the mod, and make the calculation 
		// totarget * speed * time.deltatime
		// Debug.Log(toTarget * speed * Time.deltaTime);
		// GetComponent<Rigidbody2D>().velocity = speed;
		// Debug.Log(Quaternion.Slerp(transform.position, target.transform.position, rotationSpeed*Time.deltaTime));
	}
}
