using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Movement : MonoBehaviour {
     public GameObject player;
 	 private Vector3 starttouch;
 	 private Vector3 endtouch;
 	 private Vector3 startplayer;
 	 public float speed;
     // Use this for initialization
     void Start () {
         
     }
     
     // Update is called once per frame
     void Update () {

         	foreach(Touch touch in Input.touches)
         	{
         		if(touch.phase == TouchPhase.Began)
         		{
         			starttouch = touch.position;
         			startplayer = transform.position;
         			starttouch = Camera.main.ScreenToWorldPoint(starttouch);

         		}
         		else if(touch.phase == TouchPhase.Moved)
         		{
         			endtouch = touch.position;
         			endtouch = Camera.main.ScreenToWorldPoint(endtouch);
         			Vector3 amount = endtouch - starttouch;
         			transform.position = Vector3.Lerp(startplayer + amount, startplayer + amount, speed/150);

         		}
         	}
  }
     }
