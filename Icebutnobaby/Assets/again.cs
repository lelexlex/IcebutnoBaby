using UnityEngine;
using System.Collections;

public class again : MonoBehaviour {

	int gug = 180;
	
	void Start () 
	{
		gug = timestwo (gug);
		Debug.Log (gug);

	}

	int timestwo(int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}
