using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (Input.touchCount);
		if(Input.touchCount == 1){
			//do something
			//DO LANDSCAPE
			//position range: x goes from 0 to 500, y goes from 0 to 300
			//Debug.Log (Input.GetTouch (0).position); //first element of touch array
			//Debug.Log (Input.GetTouch (0).
			/*
			if(Input.GetTouch (0).phase == TouchPhase.Began){ //for shooting button
				Debug.Log ("Touch Began");
			}
			if(Input.GetTouch (0).phase == TouchPhase.Moved){ //for all buttons, user cannot drag finger across
															  //screen to continue using buttons
				Debug.Log ("Touch Moved"); //once this happens reanalyze position of touch
										   //if position falls out of button range, then end function
			}
			if(Input.GetTouch (0).phase == TouchPhase.Ended){ //for moving buttons to end
				Debug.Log ("Touch Ended");
			}*/

			ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

			//Debug.DrawRay (ray.origin, ray.direction * 20, Color.red);

			//if(Physics.Raycast(ray, Mathf.Infinity)){ //if touch has collided with something
			if(Physics.Raycast(ray, out hit, Mathf.Infinity)){
				//when creating non-game objects like chickens or players, add
				//a box collider to them
				Debug.Log("Hit Something");
				Destroy(hit.transform.gameObject);
			}
		}
	}
}