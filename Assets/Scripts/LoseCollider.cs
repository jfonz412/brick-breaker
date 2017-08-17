using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	//if one object is a trigger (ignore physics)
	void OnTriggerEnter2D (Collider2D trigger) {
		print("Trigger");
		levelManager.LoadLevel("Lose");
	}
	
	//if niether object is a trigger (actual collisions)
	void OnCollisionEnter2D (Collision2D collision) {
		Debug.Log("Collider");
	}
}
