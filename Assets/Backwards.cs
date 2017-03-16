using UnityEngine;
using System.Collections;


public class Backwards : MonoBehaviour {
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
                Vector3 oldPos = player.transform.position;
                player.transform.Translate (+4f * Time.smoothDeltaTime, 0 , 0);
                if (player.transform.position.x > 23.5 || player.transform.position.x < -23.5 ||
                   player.transform.position.z > 23.5 || player.transform.position.z < -23.5)
                {
                    player.transform.position = oldPos;
                }

            } else if (GetComponent<GUITexture>().HitTest (touch.position) && touch.phase == TouchPhase.Ended){
				//GetComponent<GUITexture>().texture = button1;
			}
		}
	}
}

