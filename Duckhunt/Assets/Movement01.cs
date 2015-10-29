using UnityEngine;
using System.Collections;

public class Movement01 : MonoBehaviour {

	public int speed = 6;
	public int upspeed = 1;


	void Start () {
		transform.position = new Vector3 (-12, 0, 0);
			
		}

	void Update () {
		float translation2 = Time.deltaTime * upspeed;
	 	float translation = Time.deltaTime * speed;
		transform.Translate (0, translation2, 0);
		transform.Translate (translation, 0, 0);
	}

}
