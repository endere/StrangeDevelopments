using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRemoval : MonoBehaviour {
	public float despawnTime;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (despawnTime > 0)
		{
			despawnTime -= Time.deltaTime;
		}
		else
		{
			Destroy(this.gameObject);
		}
		
	}
}
