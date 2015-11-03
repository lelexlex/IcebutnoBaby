using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	public float spawntime = 4;
	public Transform[] spawnpoints;
	public GameObject snoop;


	void Start () 
	
	{
		snoop = GameObject.Find("snoop");

		InvokeRepeating ("Spawn", spawntime, spawntime);
	}

	void Spawn ()
	{
		int spawnpointindex = Random.Range (0, spawnpoints.Length);


		Instantiate (snoop, spawnpoints [spawnpointindex].position, spawnpoints [spawnpointindex].rotation);
	}
\
	void update ()
	{
		if enemycount
}
