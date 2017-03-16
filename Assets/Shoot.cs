using UnityEngine;
using System.Collections;


public class Shoot : MonoBehaviour {
	public GameObject chicken;
	public GameObject player;
	float timer;
	float timerMax;
	int amount=0;
	// Use this for initialization
	void Start () {
		//GUI.color = 0.5f;
		GetComponent<GUITexture>().color = new Color (1, 1, 1, .2f);
		timer = 0;
		timerMax = .2f;
	}
	
	// Update is called once per frame
	void Update () {

		foreach (Touch touch in Input.touches) {
			if (GetComponent<GUITexture>().HitTest (touch.position) && touch.phase != TouchPhase.Ended) {
				//GetComponent<GUITexture>().texture = button2;
				
				//.main.transform.Translate (0, 0, 5f * Time.smoothDeltaTime);
				if(timer == 0){
					GameObject newObj = (GameObject) Instantiate (chicken,player.transform.position ,(player.transform.rotation));
					//yield WaitForSeconds(2);
					Vector3 startPos;

					newObj.transform.Rotate(0,0,180f);
					newObj.transform.Translate(1f,.25f,0.5f);
					newObj.transform.localScale = new Vector3(0.15f,0.15f,0.15f);
					//newObj.clone=true;
					Destroy(newObj,5);
					float sin = Mathf.Sin(newObj.transform.eulerAngles.y*Mathf.PI/180f);
					float cos = Mathf.Cos(newObj.transform.eulerAngles.y*Mathf.PI/180f);
					//print(newObj.transform.eulerAngles.x);
					Random rnd = new Random();
					newObj.GetComponent<Rigidbody>().velocity = new Vector3(cos*Random.Range(7,9), 0, -sin*Random.Range(7,9));
					newObj.GetComponent<Rigidbody>().angularVelocity = new Vector3(cos*(Random.Range(-80f,80f)), 0, -sin*(Random.Range(-80f,80f)));
					timer += Time.deltaTime;
				}
				else{
					if(timer >= timerMax){
						timer = 0;
					}
					else{
						timer += Time.deltaTime;
					}
				}
				//Vector3 fwd = player.transform.TransformDirection(Vector3.forward);
				//print(fwd);
				//if (Physics.Raycast(transform.position, fwd, 10)) {
				//	print("There is something in front of the object!");
				//}

			//}// else if (GetComponent<GUITexture>().HitTest (touch.position) && touch.phase == TouchPhase.Ended){
				//GetComponent<GUITexture>().texture = button1;
			}
		}
	}

}
