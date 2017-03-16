using UnityEngine;
using System.Collections;

public class collisionDetection : MonoBehaviour {
	BackgroundScript script;
	// Use this for initialization
	void Start () {
		script = GameObject.Find("BackgroundProcess").GetComponent<BackgroundScript>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.tag == "chicken") {
			Destroy (other.gameObject);    
			Destroy (this.gameObject);
			script.score++;
			script.targetCounter--;
		}
	}
}
