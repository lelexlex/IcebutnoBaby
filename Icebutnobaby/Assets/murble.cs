using UnityEngine;
using System.Collections;

public class murble : MonoBehaviour {

int cucu = 40;
	void Start () 
	{
		cucu = minusten(cucu);
		Debug.Log(cucu);
	}

 int minusten(int number)
	
	{
		int ret;
		ret = number - 10;
		return ret;
	}
}
