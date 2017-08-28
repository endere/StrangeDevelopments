using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	// // Use this for initialization
	// void Start () {
		
	// }
	
	// // Update is called once per frame
	// void Update () {
	// }
	public float playerHealth;
	void OnCollisionEnter2D(Collision2D collision)
	{	
		if (collision.gameObject.name=="Bullet(Clone)")
		{
			playerHealth -= 1;
			Destroy(collision.gameObject);
			if (playerHealth == 0)
            {
                Destroy(this.gameObject);
            }

		}
	}
}
