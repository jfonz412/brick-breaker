using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3(Mathf.Clamp(8.0f,0.5f,15.5f), this.transform.position.y, 0f);
		float mousePosInblocks = Input.mousePosition.x / Screen.width * 16; //16 for 16 total blocks *

		paddlePos.x = Mathf.Clamp (mousePosInblocks, 0.5f, 15.5f);
		this.transform.position = paddlePos;
	}
}

//* Background sprite is 800 wide, we set the background image's pixel per world block to 50 pixels per block,
// 800/50 = 16 blocks