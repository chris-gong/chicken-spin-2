using UnityEngine;
using System.Collections;


public class RotateLeft : MonoBehaviour {
	public GameObject player;
	
	//public GUITexture guiTexture;
	
	// Use this for initialization
	void Start () {
		//GetComponent<GUITexture>().texture = button1;
		GetComponent<GUITexture>().color = new Color (1, 1, 1, .2f);
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if (GetComponent<GUITexture>().HitTest (touch.position) && touch.phase != TouchPhase.Ended) {
				//GetComponent<GUITexture>().texture = button2;
				
				//.main.transform.Translate (0, 0, 5f * Time.smoothDeltaTime);
				player.transform.Rotate (0, 0,-200f* Time.smoothDeltaTime);
			} else if (GetComponent<GUITexture>().HitTest (touch.position) && touch.phase == TouchPhase.Ended){
				//GetComponent<GUITexture>().texture = button1;
			}
		}
	}
}

