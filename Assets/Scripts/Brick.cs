using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public AudioClip crack;	
	public Sprite[] hitSprites;
	//static or class vars are not shown in inspecter even if public
	public static int breakableCount = 0; //can also do this in Start()
	
	private int timesHit;
	private LevelManager levelmanager;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if(isBreakable){
			breakableCount++;
		}
		timesHit = 0;
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	//this is it's own event, like Update/Start
	void OnCollisionEnter2D(Collision2D coll) {
		if(isBreakable){
			//create audiosource where clip brick is or was
			AudioSource.PlayClipAtPoint(crack,transform.position, 0.2f);
			HandleHits();
		}
	}
	
	void HandleHits(){
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if(timesHit >= maxHits){
			breakableCount--;
			levelmanager.BrickDestroyed();
			Destroy (gameObject); //not '.this'
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
