﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Paddle paddle;
	private Vector3 ballToPaddlePos;
	private bool hasStarted = false;
	
	// Use this for initialization
	void Start () {
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
				this.rigidbody2D.velocity = new Vector2(2f,10f);
			}
		}
	}
}