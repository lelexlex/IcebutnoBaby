using UnityEngine;
using System.Collections;

public class Snopesandaccess : MonoBehaviour {


	public int a1= 0;
	

	private Anotherclass rapgod;
	// Use this for initialization

	void Start () {
		a1 = 42;
	}


	void FixedUpdate () {
		Debug.Log("a1 is set to " + a1);
	}
}	