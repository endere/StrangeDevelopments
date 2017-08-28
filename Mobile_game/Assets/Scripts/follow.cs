using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {
	// public GameObject target;
	public float speed;
	public float rotationSpeed;
	private Vector3 target;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		target = GameObject.Find("Player").transform.position;
		Vector3 toTarget = target - transform.position;
		transform.Translate(toTarget * speed * Time.deltaTime);
		// Debug.Log(target.gameObject.name);
		// Debug.Log(Quaternion.Slerp(transform.position, target.transform.position, rotationSpeed*Time.deltaTime));
	}
}
