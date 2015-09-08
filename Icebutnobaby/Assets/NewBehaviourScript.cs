using UnityEngine;
using System.Collections;

public class Letsdoit : MonoBehaviour {

	int myint = 4;

	void Start () {
		myint = subtractthree(myint);
		Debug.Log (myint);
	}


	int subtractthree (int number)
	{
		int ret;
		ret = number - 3;
		return ret;
	}
}
