using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {
	public GameObject enemy;
	public GameObject[] enemies;
	public float delay;
	private float minx = -3f;
	private float maxx = 3f;
	private float miny = -5.7f;
	private float maxy = 4.1f;
	private float newx;
	private float newy;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", delay, delay);
	}
	
	// Update is called once per frame
	void Spawn () {
		newx = Random.Range(minx, maxx);
		newy = Random.Range(miny, maxy);
		Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length)], new Vector3(newx, newy, 0), Quaternion.identity);
	}
}
