using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	public static int musicPlayerCount = 0;
	
	// Use this for initialization
	void Start () {
		musicPlayerCount++;
		
		if(musicPlayerCount > 1) {
			Destroy(gameObject);
		}
		
		GameObject.DontDestroyOnLoad(gameObject); // prevents gameObject from being destroyed when a new scene is loaded
	}
}
