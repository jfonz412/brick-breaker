﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {	
	public Sprite[] hitSprites;

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
		bool isBreakable = (this.tag == "Breakable");
		if(isBreakable){
			HandleHits();
		}
	}
	
	void HandleHits(){
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if(timesHit >= maxHits){
			Destroy (gameObject); //not .this
		}else {
			LoadSprites();
		}
	}
	
	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		if (hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
	
	// TODO Remove this method once we can actually win
	void SimulateWin(){
		levelmanager.LoadNextLevel();
	}
}
