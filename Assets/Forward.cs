using UnityEngine;
using System.Collections;


public class Forward : MonoBehaviour {
	public GameObject player;
	 
	//public GUITexture guiTexture;

	// Use this for initialization
	void Start () {
		//GetComponent<GUITexture>().texture = button1;
		GetComponent<GUITexture>().color = new Color (1, 1, 1, .2f);

	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 pos = player.transform.position;
		//pos.x = Mathf.Clamp(player.transform.position.x, -22.5f, 22.5f);
		foreach (Touch touch in Input.touches) {
			if (GetComponent<GUITexture>().HitTest (touch.position) && touch.phase != TouchPhase.Ended) {
				//GetComponent<GUITexture>().texture = button2;

				//main.transform.Translate (0, 0, 5f * Time.smoothDeltaTime);
				Vector3 oldPos = player.transform.position;
                Vector3 newPos = player.transform.position + new Vector3(-6f * Time.deltaTime,0,0);
                player.transform.Translate (-6f * Time.smoothDeltaTime, 0 , 0);
                Vector3 velocity = Vector3.zero;
                //player.transform.position = Vector3.Lerp(oldPos, newPos ,0.6f);
                //player.transform.position = Vector3.SmoothDamp(player.transform.position, new Vector3(-6f * Time.smoothDeltaTime, 0, 0), ref velocity, 0.3f);
                if (player.transform.position.x > 23.5 || player.transform.position.x < -23.5 ||
				   player.transform.position.z > 23.5 || player.transform.position.z < -23.5){
					player.transform.position = oldPos;
				}
				//pos = player.transform.position;
				//pos.x = Mathf.Clamp(player.transform.position.x, -22.5f, 22.5f);
			} else if (GetComponent<GUITexture>().HitTest (touch.position) && touch.phase == TouchPhase.Ended){
				//GetComponent<GUITexture>().texture = button1;
			}
		}
	}

	void OnCollisionEnter(Collision other)
	{
	
		if (other.gameObject.tag == "wall") {
			Destroy (other.gameObject);    
			Destroy (this.gameObject);

		}
	}
}
