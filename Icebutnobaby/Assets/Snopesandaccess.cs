using UnityEngine;
using System.Collections;

public class Snopesandaccess : MonoBehaviour {


	public int a1= 0;
	

	private Anotherclass rapgod;
	// Use this for initialization
	void Start () {
		a1 = 42;
	}

	void example (int eminem, int god){
		int answer;
		answer = eminem * god * a1;
		Debug.Log (answer);
	}
}
