using UnityEngine;
using System.Collections;

public class foreach : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		string[] strings = new string[3];
		
		
		string[0] = "one";
		string[1] = "two";
		string[2] = "three";
		
		foreach(string item in strings)
		{
			print (item);
		}
}
	