using UnityEngine;
using System.Collections;

public class hubaloo : MonoBehaviour {

	int nips = 76;

	void Start () 
	{
		nips = cucu (nips);
		Debug.Log (nips);
	}

	int cucu (int number)
	{
		int ret;
		ret = number + 50;
		return ret;
	}
}
