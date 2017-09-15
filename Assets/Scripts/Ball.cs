using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private Vector3 ballToPaddlePos;
	private bool hasStarted = false;
	
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		ballToPaddlePos = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted){
			// Lock ball to paddle
			this.transform.position = paddle.transform.position + ballToPaddlePos;	
			// Wait for mouse input
			if(Input.GetMouseButtonDown(0)){
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2(2f,8f);
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D coll){
		Vector2 tweak = new Vector2(Random.Range(0f, 0.2f),Random.Range(0f, 0.2f));
		
		if(hasStarted){
			if (coll.gameObject.tag != "Breakable"){
				audio.Play();
			}
			rigidbody2D.velocity += tweak;
		}
	}
}
