using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackgroundScript : MonoBehaviour {
	public GameObject target;
	public int targetCounter;
	public int score;
	float countDown;

	//spawn range x: -22 to 22
	//spawn range z: -22 to 22
	//spawn range y: 0.5
	//spawn scaling: 0.1 on all axises
	// Use this for initialization
	void Start () {
		targetCounter = 5;
		countDown = 60;
		setTargets();
	}
	
	// Update is called once per frame
	void Update () {
        if (countDown > 0)
        {
            Debug.Log(countDown);
            Debug.Log(score);
            if (targetCounter < 1)
            {
                setTargets();
                targetCounter = 5;
            }
            countDown -= Time.deltaTime;
        }
        else
        {
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene("GameOverScene");
        }
	}
	/*void OnCollisionEnter(Collision other)
	{
		Debug.Log ("Hi");
		if (other.gameObject.tag == "chicken") {
			Destroy (other.gameObject);    
			Destroy (this.gameObject);
			Debug.Log ("Destroyed");
		}
		score++;
		targetCounter--;
	}*/
	/*void OnCollisionEnter(Collision other)
	{
		
		if (other.gameObject.tag == "chicken") {
			Destroy (other.gameObject);    
			Destroy (this.gameObject);
		}
	}*/
	void setTargets(){
		float x, y, z;
		for(int i = 5; i > 0; i--){
			x = UnityEngine.Random.Range(-22.5f, 22.5f);
			y = 0.5f;
			z = UnityEngine.Random.Range(-22.5f, 22.5f);
			GameObject newObj = (GameObject) Instantiate (target,new Vector3(x,y,z) ,(target.transform.rotation));
		}
	}
}
