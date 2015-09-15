using UnityEngine;
using System.Collections;

public class passoff : MonoBehaviour {

	int four = 4;

	void Start () 
	{
		four = plusten (four);
		Debug.Log (four);
	}

	int plusten(int number)
	{
		int ret;
		ret = number + 10;
		return ret;
	}
}