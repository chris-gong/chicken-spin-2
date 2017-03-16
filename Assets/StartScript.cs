using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Touch touch in Input.touches)
        {
            if (GetComponent<GUITexture>().HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
}
