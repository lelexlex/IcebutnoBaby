using UnityEngine;
using System.Collections;

public class Ifelse : MonoBehaviour {

	float mine=80;

	//add float and getkeydown
	void Start () 
	
	{

	}

	void Update () 
		{
		if (Input.GetKeyDown (KeyCode.Space))
			Test ();

		mine -= Time.deltaTime * 3;
		}


		void Test()
		{
			if (mine > 54){
				print ("I'm more than 54");
			} else if (mine < 54) {
				print ("I'm less than 54");
			}
		}
}
