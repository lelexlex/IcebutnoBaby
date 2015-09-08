using UnityEngine;
using System.Collections;

public class eggyjustice : MonoBehaviour {

	int egg = 7890;

	void Start () 
	{
		egg = scramble (egg);	
		Debug.Log(egg);
	}

	int scramble(int number)
	{
		int ret;
		ret = number / 45;
		return ret;
	}
}
