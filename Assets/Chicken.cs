using UnityEngine;
using System.Collections;


public class Chicken: MonoBehaviour {
	public bool clone= false;
	static int amount=0;
	
	void Start(){
		
	}
	void Update(){
		if(clone == true){
			Destroy(this,5);
		}
	}
}