using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public int maxHits;
	private int timesHit;
	private LevelManager levelmanager;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	//this is it's own event, like Update/Start
	void OnCollisionEnter2D(Collision2D coll) {
		timesHit++;
		Debug.Log(timesHit);
		SimulateWin ();
	}
	
	// TODO Remove this method once we can actually win
	void SimulateWin(){
		levelmanager.LoadNextLevel();
	}
}
