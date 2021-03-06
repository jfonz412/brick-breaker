﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
	{
		Brick.breakableCount = 0;
		Application.LoadLevel(name);
	}
	
	public void QuitRequest()
	{
		Debug.Log("Quit requested");
		Application.Quit();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	//helps Brick talk to LevelManager
	public void BrickDestroyed(){
		// you can call a class's public static from the class itself
		if (Brick.breakableCount <= 0){
			LoadNextLevel();
		}
	}
}
