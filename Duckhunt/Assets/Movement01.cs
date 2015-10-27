using UnityEngine;
using System.Collections;

public class Movement01 : MonoBehaviour {

	public int speed = 5;


	void Start () {
		transform.position = new Vector3 (0, 0, 0);
			print (transform.position.y);
		}

	void Update () {
	 	float translation = Time.deltaTime * speed;
		transform.Translate (translation, 0, 0);
	}

}
