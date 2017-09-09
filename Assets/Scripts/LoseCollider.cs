using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void Start(){
		
	}
	//if one object is a trigger (ignore physics)
	void OnTriggerEnter2D (Collider2D trigger) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadLevel("Lose");		
	}
	
	//if niether object is a trigger (actual collisions)
	void OnCollisionEnter2D (Collision2D collision) {
		Debug.Log("Collider");
	}
}
