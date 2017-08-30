using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D collision)
	{	
		if (collision.gameObject.tag=="enemy")
		{
			
			Destroy(collision.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
