using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootScript : MonoBehaviour {
	public GameObject ProjectileObject;
	public float projectileTimeOut;
	public float startingVelocity;
	private float timeCounter = 0;
	private int rotation = 0;
	private int num1;
	private int num2;

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

	        GameObject clone = Instantiate(ProjectileObject, transform.position, Quaternion.identity);
	        Rigidbody2D projPhysics = clone.GetComponent<Rigidbody2D>();
	        switch(rotation){
	        	case 0:
	        		num1= -1;
	        		num2= 0;
	        		break;
	        	case 1:
	        		num1= -1;
	        		num2= 1;
	        		break;
	        	case 2:
	        		num1= 0;
	        		num2= 1;
	        		break;
	        	case 3:
	        		num1= 1;
	        		num2= 1;
	        		break;
	        	case 4:
	        		num1= 1;
	        		num2= 0;
	        		break;
	        	case 5:
	        		num1= 1;
	        		num2= -1;
	        		break;
	        	case 6:
	        		num1= 0;
	        		num2= -1;
	        		break;
	        	case 7:
	        		num1= -1;
	        		num2= -1;
	        		break;
	        }


	        projPhysics.AddForce(transform.up * num1 * startingVelocity);
	        projPhysics.AddForce(transform.right * num2 * startingVelocity);
	        timeCounter = projectileTimeOut;
	        if(rotation < 7){
	        	rotation += 1;
	        }
	        else{
	        	rotation = 0;
	        }
		}
	}
}
