using UnityEngine;
using System.Collections;

public class yetagain : MonoBehaviour {

	int bub = 420;

	void Start () 
	{
		bub = dividedtwo (bub);
		Debug.Log (bub);
	}

	int dividedtwo (int number)
	{
		int ret;
		ret = number / 2;
		return ret;
	}
}
