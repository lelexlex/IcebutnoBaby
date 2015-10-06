using UnityEngine;
using System.Collections;

public class forloop : MonoBehaviour {

	int enemies = 3;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < enemies; i++) {
			Debug.Log ("adding enemies:" + i);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
