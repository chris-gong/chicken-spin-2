using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {
    public int score;
    GUIText text;
    // Use this for initialization
    void Start () {
        score = PlayerPrefs.GetInt("Score");
        text = GameObject.Find("Score").GetComponent<GUIText>();
        text.fontSize = Screen.width/20;
        Debug.Log(text.fontSize);
        text.text = "Your score was " + score + " neutrons";
    }
	
	// Update is called once per frame
	void Update () {
        foreach (Touch touch in Input.touches)
        {
            if (GetComponent<GUITexture>().HitTest(touch.position) && touch.phase != TouchPhase.Ended)
            {
                SceneManager.LoadScene("StartScene");
            }
        }
    }
}
