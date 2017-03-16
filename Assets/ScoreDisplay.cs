using UnityEngine;
using System.Collections;

public class ScoreDisplay : MonoBehaviour {
    GUIText text;
    // Use this for initialization
    void Start () {
        text = GameObject.Find("Score").GetComponent<GUIText>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
