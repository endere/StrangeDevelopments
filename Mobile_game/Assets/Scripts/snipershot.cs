using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snipershot : MonoBehaviour {
	public GameObject ProjectileObject;
	public float projectileTimeOut;
	public float startingVelocity;
	private float timeCounter = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(timeCounter > 0)
		{
			timeCounter -= Time.deltaTime;
		}	
		else
		{
			Vector3 target = GameObject.Find("Player").transform.position;
			Vector3 dir = (target - transform.position).normalized;
			GameObject clone = Instantiate(ProjectileObject, transform.position, Quaternion.identity);
			clone.GetComponent<Rigidbody2D>().AddForce(dir * startingVelocity);   
			timeCounter = projectileTimeOut;
   
		}
	}
}
