using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {
	public int sceneInt;
	// Use this for initialization
	void Start () {
		sceneInt = SceneManager.GetActiveScene().buildIndex;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Clicked () {
		Time.timeScale = 1; // unpause
		Gas.gasAmount = 100;//resetting static variables for level restart

		SceneManager.LoadScene (sceneInt);
}
}