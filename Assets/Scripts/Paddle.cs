using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public bool autoPlay = false;
	private Ball ball;
	
	void Start(){
		ball = GameObject.FindObjectOfType<Ball>();
		print(ball);
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay){
			MoveWithMouse();
		}else {
			AutoPlay();
		}
	}
	
	void MoveWithMouse(){
		Vector3 paddlePos = new Vector3(Mathf.Clamp(8.0f,0.5f,15.5f), this.transform.position.y, 0f);
		float mousePosInblocks = Input.mousePosition.x / Screen.width * 16; //16 for 16 total blocks *		
		paddlePos.x = Mathf.Clamp (mousePosInblocks, 0.5f, 15.5f);
		this.transform.position = paddlePos;
	}
	
	void AutoPlay(){
		Vector3 paddlePos = new Vector3(Mathf.Clamp(8.0f,0.5f,15.5f), this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;		
		paddlePos.x = Mathf.Clamp (ballPos.x, 0.5f, 15.5f);
		this.transform.position = paddlePos;
	}
}

//* Background sprite is 800 wide, we set the background image's pixel per world block to 50 pixels per block,
// 800/50 = 16 blocks