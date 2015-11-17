using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	public float spawntime = 2;
	public GameObject [] dog;
	/*public int amount = 0;*/


	public Vector3 spawnpoint;



	/*void Update()
	{
		dog = GameObject.FindGameObjectsWithTag ("Enemy");
		

		if (amount < 1)
		{
		
			InvokeRepeating ("Spawn", spawntime, spawntime);
			amount = "amount + 1";

		}

		else (amount > 1);
		{
			CancelInvoke("Spawn");
		}
		
	}*/




		/*Instantiate (snoop, spawnpoints [spawnpointindex].position, spawnpoints [spawnpointindex].rotation);*/

	void Spawn()
	{
		dog = GameObject.FindGameObjectsWithTag ("Enemy");


		spawnpoint.x = Random.Range (-10, 10);
		spawnpoint.y = Random.Range (-2, 3);
		spawnpoint.z = 0;

		Instantiate (dog [UnityEngine.Random.Range (0, dog.Length)], spawnpoint, Quaternion.identity);
		CancelInvoke ();
	}
	
}
/*Spawn this instance, add rigidbody. ignore top*/