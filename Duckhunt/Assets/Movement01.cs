using UnityEngine;
using System.Collections;

public class Movement01 : MonoBehaviour {

	public int speed = 4;
	public int upspeed = 1;


	
	void Update () {
		float translation2 = Time.deltaTime * upspeed;
	 	float translation = Time.deltaTime * speed;
		transform.Translate (0, translation2, 0);
		transform.Translate (translation, 0, 0);
	}

}


/* Check vector 2 movement. Could save time http://pixelnest.io/tutorials/2d-game-unity/player-and-enemies/ */