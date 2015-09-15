using UnityEngine;
using System.Collections;

public class practicemakespineapple : MonoBehaviour {
	int butts = 0;

	void Start () {
		butts = plusthousand (butts);
		Debug.Log (butts);
	}

	int plusthousand(int number)
	{
		int ret;
		ret = number + 1000;
		return ret;
	}
}
